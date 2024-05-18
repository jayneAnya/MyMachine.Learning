using MyMachine_Learning;
// Add input data
Console.WriteLine("Enter your sample data:");
string userInput = Console.ReadLine();

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = userInput
};

// Load model and predict output of sample data
var result = SentimentModel.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");