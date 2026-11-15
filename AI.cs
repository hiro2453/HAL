using Microsoft.ML;
using Microsoft.ML.Data;

namespace haiandro
{
    internal class AI
    {
        // AIに学習・予測させるための入力データ
        public class HighLowInput
        {
            public float CurrentCard { get; set; }         // 現在の場のカード (1〜13)
            public float RemainingHighCount { get; set; }  // 山札に残っている「現在より高いカード」の枚数
            public float RemainingLowCount { get; set; }   // 山札に残っている「現在より低いカード」の枚数

            [ColumnName("Label")]
            public bool IsNextHigher { get; set; }         // 正解データ（次のカードが高ければ true、低ければ false）
        }

        // AIからの予測結果を受け取るクラス
        public class HighLowPrediction
        {
            [ColumnName("PredictedLabel")]
            public bool PredictedIsHigher { get; set; }    // AIの判断結果（true / false）

            public float Probability { get; set; }         // その判断の確信度（0.0〜1.0）
        }

        public class ModelTrainer
        {
            public static void TrainAndSaveModel(string modelPath)
            {
                var mlContext = new MLContext(seed: 42);

                // 1. シミュレーションで学習データを10,000件生成
                var trainingDataList = GenerateSimulationData(10000);
                IDataView dataView = mlContext.Data.LoadFromEnumerable(trainingDataList);

                // データを「学習用(80%)」と「テスト用(20%)」に分割
                var splitData = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);

                // 2. 学習パイプラインの構築
                // 入力する3つの数値を「Features」という1つの特徴量グループにまとめ、FastTree（勾配ブースティング木）で学習
                var pipeline = mlContext.Transforms.Concatenate(
                        "Features",
                        nameof(HighLowInput.CurrentCard),
                        nameof(HighLowInput.RemainingHighCount),
                        nameof(HighLowInput.RemainingLowCount))
                    .Append(mlContext.BinaryClassification.Trainers.FastTree(
                        labelColumnName: "Label",
                        featureColumnName: "Features"));

                // 3. モデルの学習を実行
                Console.WriteLine("学習を開始します...");
                ITransformer model = pipeline.Fit(splitData.TrainSet);

                // 4. テストデータで精度を評価
                var predictions = model.Transform(splitData.TestSet);
                var metrics = mlContext.BinaryClassification.Evaluate(predictions, labelColumnName: "Label");
                Console.WriteLine($"学習完了！ 正解率 (Accuracy): {metrics.Accuracy:P2}");

                // 5. 学習済みモデルをファイルに保存（次回からはこのファイルを読み込むだけで使える）
                mlContext.Model.Save(model, dataView.Schema, modelPath);
            }

            // 学習用のプレイデータを自動生成するヘルパーメソッド
            private static List<HighLowInput> GenerateSimulationData(int gameCount)
            {
                var data = new List<HighLowInput>();
                var rng = new Random(42);

                for (int g = 0; g < gameCount; g++)
                {
                    // 1デッキ(52枚)を作成してシャッフル
                    var deck = Enumerable.Range(1, 13).SelectMany(n => Enumerable.Repeat(n, 4)).OrderBy(_ => rng.Next()).ToList();

                    for (int i = 0; i < deck.Count - 1; i++)
                    {
                        int current = deck[i];
                        int next = deck[i + 1];

                        // 引き分け（同じ数字）は学習対象から除外する場合
                        if (current == next) continue;

                        var remainingDeck = deck.Skip(i + 1).ToList();

                        data.Add(new HighLowInput
                        {
                            CurrentCard = current,
                            RemainingHighCount = remainingDeck.Count(c => c > current),
                            RemainingLowCount = remainingDeck.Count(c => c < current),
                            IsNextHigher = next > current
                        });
                    }
                }
                return data;
            }
        }

        public class HighLowAiPredictor
        {
            private readonly PredictionEngine<HighLowInput, HighLowPrediction> _predictionEngine;

            public HighLowAiPredictor(string modelPath)
            {
                var mlContext = new MLContext();
                // 保存済みのモデルを読み込む
                ITransformer loadedModel = mlContext.Model.Load(modelPath, out _);
                // 1件ずつ高速に予測するためのエンジンを作成
                _predictionEngine = mlContext.Model.CreatePredictionEngine<HighLowInput, HighLowPrediction>(loadedModel);
            }

            // 現在の盤面を渡して true (High) か false (Low) を返すメソッド
            public bool ShouldBetHigh(int currentCard, int remainingHighCount, int remainingLowCount)
            {
                var input = new HighLowInput
                {
                    CurrentCard = currentCard,
                    RemainingHighCount = remainingHighCount,
                    RemainingLowCount = remainingLowCount
                };

                HighLowPrediction result = _predictionEngine.Predict(input);

                // デバッグ用に確信度も見たい場合は result.Probability を参照できます
                return result.PredictedIsHigher;
            }
        }
    }
}
