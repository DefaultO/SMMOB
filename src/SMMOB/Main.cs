using CefSharp;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SMMOBML.Model;
using Microsoft.ML.Data;
using Microsoft.ML;
using System.Linq;

namespace SMMOB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            browser.IsBrowserInitializedChanged += OnIsBrowserInitializedChanged;
            browser.LoadingStateChanged += OnLoadingStateChanged;
            browser.ConsoleMessage += OnBrowserConsoleMessage;
            browser.StatusMessage += OnBrowserStatusMessage;
            browser.TitleChanged += OnBrowserTitleChanged;
            browser.AddressChanged += OnBrowserAddressChanged;

            Thread bot_logic = new Thread(Bot);
            bot_logic.Start();
        }

        private void OnIsBrowserInitializedChanged(object sender, EventArgs e)
        {

        }

        private void OnBrowserConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            if (args.Message.Contains("[>]"))
            {
                if (args.Message == "[>] Please solve Captcha to continue")
                {
                    browser.LoadUrlAsync("https://web.simple-mmo.com/i-am-not-a-bot");
                }
                if (args.Message == "[>] Captcha solved")
                {
                    browser.LoadUrlAsync("https://web.simple-mmo.com/travel");
                }
                // [>] Level: 1
                // [1030 / 202506.454:INFO: CONSOLE(1)] "[>] Level: 1", source: about: blank(1)
                // Console.WriteLine(args.Message.Substring(args.Message.IndexOf("[>]"), args.Message.IndexOf("\n") - 1));
            }
            if (args.Message.Contains("[Captcha]"))
            {
                captcha_log = args.Message;
            }
        }

        private void OnBrowserStatusMessage(object sender, StatusMessageEventArgs args)
        {

        }

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {

        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs args)
        {

        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            if (loggingIn && args.Address == "https://web.simple-mmo.com/home")
            {
                
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            browser.LoadUrlAsync("https://web.simple-mmo.com/login");
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            password.PasswordChar = password.PasswordChar == '*' ? '\0' : '*';
        }


        bool loggingIn = false;
        private void login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(email.Text) || String.IsNullOrEmpty(password.Text)) return;

            // Input E-Mail + Password
            browser.EvaluateScriptAsync(
                $"var input_email = document.getElementById('email');" +
                $"var input_password = document.getElementById('password');" +
                $"input_email.setAttribute('value', '{email.Text}');" +
                $"input_password.setAttribute('value', '{password.Text}');"
                );

            // Click Login Button
            browser.EvaluateScriptAsync(
                $"var button_login = document.getElementsByClassName('w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500')[0].click();"
                );

            loggingIn = true;
        }

        private void update_Tick(object sender, EventArgs e)
        {

        }

        private void performAttack()
        {
            #region Javascript
            browser.EvaluateScriptAsync(// Close Button in Popup after fight
                                        "var close_button = document.getElementsByClassName('mt-10 app-btn btn-primary inline-flex items-center px-3 py-2 border border-gray-300 shadow-sm text-sm leading-4 font-medium rounded-md text-gray-700 bg-white hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500')[0];" +
                                        "if (close_button != undefined)" +
                                        "{" +
                                            "close_button.click();" +
                                        "}" +

                                        // Click on Attack
                                        "var attack_button = document.getElementById('attackButton');" +
                                        "if (attack_button != undefined)" +
                                        "{" +
                                            "if (!attack_button.disabled)" +
                                            "{" +
                                                "attack();" +
                                            "}" +
                                        "}"
                                        );
            #endregion
            /*
            // Litle Hold Mouse Button Down function
                                        "function simulateMouseEvent(el, event)" +
                                        "{" +
                                        "if (window.MouseEvent && typeof window.MouseEvent === 'function')" +
                                        "{" +
                                        "var event = new MouseEvent(event);" +
                                        "} else {" +
                                        "var event = document.createEvent('MouseEvent');" +
                                        "event.initMouseEvent(event);" +
                                        "}" +
                                        "el.dispatchEvent(event);" +
                                        "}" +

                                        // Hold Gathering Button down for 3 seconds
                                        "var action_button = document.getElementById('action_button');" +
                                        "if (action_button != undefined)" +
                                        "{" +
                                            "simulateMouseEvent(action_button, 'mousedown')" +
                                            "setTimeout(() => {" +
                                            "simulateMouseEvent(action_button, 'mouseup')" +
                                            "}, 3000);" +
                                        "}" +

            // Close Button in Gathering Page
                                        "var close_button = document.getElementsByClassName('relative px-3 py-2 border border-gray-300 shadow-sm text-sm leading-4 font-medium rounded-md text-gray-700 bg-white hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500 btn-secondary btn-primary')[0];" +
                                        "if (close_button != undefined)" +
                                        "{" +
                                            "close_button.click();" +
                                        "}" +

            */
        }

        private void performStep()
        {
            /*
            // Check if level is too small for gathering things
                                        "var small_text = document.getElementsByTagName('small')[1];" +
                                        "if (small_text == null)" +
                                        "{" +
                                            // Pickup Stuff
                                            "var pick_button = document.getElementsByClassName('inline-flex items-center px-3 py-2 border border-transparent dark:text-white dark:bg-indigo-600 dark:hover:bg-indigo-700 text-sm leading-4 font-medium rounded-md shadow-sm text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500')[0];" +
                                            "if (pick_button != undefined && pick_button.textContent.toLowerCase().includes('pick'))" +
                                            "{" +
                                                "pick_button.click();" +
                                            "}" +
                                            // Salvage Stuff
                                            "var salvage_button = document.getElementsByClassName('inline-flex items-center px-3 py-2 border border-transparent dark:text-white dark:bg-indigo-600 dark:hover:bg-indigo-700 text-sm leading-4 font-medium rounded-md shadow-sm text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500')[1];" +
                                            "if (salvage_button != undefined && salvage_button.text == '  Salvage')" +
                                            "{" +
                                                "salvage_button.click();" +
                                            "}" +
                                        "}" +
            */
            #region Javascript
            browser.EvaluateScriptAsync("var captcha_button = document.getElementsByClassName('btn btn-primary inline-flex items-center px-3 py-2 border border-transparent text-sm leading-4 font-medium rounded-md shadow-sm text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500')[0];" +
                                        "if (captcha_button != undefined)" +
                                        "{" +
                                            "if (captcha_button.text == 'Press here to verify')" +
                                            "{" +
                                                "console.log('[>] Please solve Captcha to continue');" +
                                            "}" +
                                        "}");

            browser.EvaluateScriptAsync(// Start Attack
                                        "var start_attack_button = document.getElementsByClassName('btn btn-success  inline-flex items-center px-3 py-2 border border-transparent dark:text-white dark:bg-indigo-600 dark:hover:bg-indigo-700 text-sm leading-4 font-medium rounded-md shadow-sm text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500')[0];" +
                                        "if (start_attack_button != undefined)" +
                                        "{" +
                                            "start_attack_button.click();" +
                                        "}" +

                                        "var travel_text = document.getElementsByClassName('travel-text text-gray-500 text-center dark:text-gray-300')[0].textContent;" +
                                        "if (travel_text == 'Please complete the human verification. Press here to verify')" +
                                        "{" +
                                            "document.getElementByClassName('btn btn-primary inline-flex items-center px-3 py-2 border border-transparent text-sm leading-4 font-medium rounded-md shadow-sm text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500')[0].click();" +
                                        "}" +
                                        "else" +
                                        "{" +
                                            "if (!document.getElementById('primaryStepButton').disabled)" +
                                            "{" +
                                                "performStep();" +
                                            "}" +
                                        "}"
                                        );
            #endregion
        }

        /// <summary>
        /// Uses concatenated then SubStringed GUIDs to get a random string of the
        /// desired length. Relies on the randomness of the GUID generation algorithm.
        /// </summary>
        /// <param name="stringLength">Length of string to return</param>
        /// <returns>Random string of <paramref name="stringLength"/> characters</returns>
        internal static string GetRandomString(int stringLength)
        {
            StringBuilder sb = new StringBuilder();
            int numGuidsToConcat = (((stringLength - 1) / 32) + 1);
            for (int i = 1; i <= numGuidsToConcat; i++)
            {
                sb.Append(Guid.NewGuid().ToString("N"));
            }

            return sb.ToString(0, stringLength);
        }

        public void SaveImage(string imageUrl, string filename, ImageFormat format)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap; bitmap = new Bitmap(stream);

            if (bitmap != null)
            {
                bitmap.Save(filename, format);
            }

            stream.Flush();
            stream.Close();
            client.Dispose();
        }

        string captcha_log = "";
        private void solveCaptcha()
        {
            // Check if there is a captcha
            #region Javascript
            browser.EvaluateScriptAsync("var looking_for = document.getElementsByClassName('text-2xl text-gray-800 font-semibold')[0];" +
                                        "if (looking_for != null && looking_for.parentNode.parentElement.className != ' hidden ')" +
                                        "{" +
                                            "console.log('[Captcha] Looking for ' + looking_for.textContent);" +
                                        "}"
                                        );
            #endregion

            // Wait for the console message to get logged into captcha_log
            while (String.IsNullOrEmpty(captcha_log))
            {
                Thread.Sleep(1000);
            }

            // Determine what we are looking for and or if we got a captcha
            string captcha = "";
            if (captcha_log.Contains("Looking for"))
            {
                captcha = captcha_log.Replace("[Captcha] Looking for ", "");
            }
            else
            {
                return; // Captcha not found
            }

            string[] image = new string[] {
                $"C:\\Users\\breit\\source\\repos\\SMMOB\\SMMOB\\assets\\captcha_temp\\0.png",
                $"C:\\Users\\breit\\source\\repos\\SMMOB\\SMMOB\\assets\\captcha_temp\\1.png",
                $"C:\\Users\\breit\\source\\repos\\SMMOB\\SMMOB\\assets\\captcha_temp\\2.png",
                $"C:\\Users\\breit\\source\\repos\\SMMOB\\SMMOB\\assets\\captcha_temp\\3.png"
            };

            browser.DownloadHandler = new MyCustomDownloadHandler();
            for (int i = 0; i < image.Length; i++)
            {
                browser.StartDownload($"https://web.simple-mmo.com/i-am-not-a-bot/generate_image?uid={i}");
                Thread.Sleep(5000);
                if (File.Exists(@"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha_temp\generate_image.png"))
                {
                    File.Move(@"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha_temp\generate_image.png", @"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha_temp\" + i + ".png");
                }
            }

            // Predict what the images are using our mashine learning dataset
            int predictedIndex = -1;
            float bestAcc = 0.0f;
            for (int i = 0; i < image.Length; i++)
            {
                if (File.Exists(@"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha_temp\" + i + ".png"))
                {
                    // Create single instance of sample data from first line of dataset for model input
                    ModelInput sampleData = new ModelInput()
                    {
                        ImageSource = @"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha_temp\" + i + ".png",
                    };

                    // Make a single prediction on the sample data and print results
                    var predictionResult = ConsumeModel.Predict(sampleData);

                    var mlContext = new MLContext();
                    var transformer = mlContext.Model.Load(@"C:\Users\breit\source\repos\SMMOB\SMMOBML.Model\MLModel.zip", out _);
                    var predictionEngine = mlContext.Model
                        .CreatePredictionEngine<ModelInput, ModelOutput>(transformer);

                    var labelBuffer = new VBuffer<ReadOnlyMemory<char>>();
                    predictionEngine.OutputSchema["Score"].Annotations.GetValue("SlotNames", ref labelBuffer);
                    var labels = labelBuffer.DenseValues().Select(l => l.ToString()).ToArray();

                    var index = Array.IndexOf(labels, predictionResult.Prediction);
                    var score = predictionResult.Score[index];
                    Console.WriteLine($"Predicted {predictionResult.Prediction} by {score * 100}%");

                    Console.WriteLine($"[>] {predictionResult.Prediction} == {captcha}");
                    Console.WriteLine($"{score} > 0.5f?");
                    if (score > 0.7f)
                    {
                        File.Copy(image[i], @"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha\" + $"{predictionResult.Prediction}\\{GetRandomString(10)}.png");
                        if (predictionResult.Prediction == captcha)
                        {
                            if (score > bestAcc)
                            {
                                bestAcc = score;
                                predictedIndex = i;
                                Console.WriteLine($"Detected {predictionResult.Prediction} with {predictionResult.Score[0] * 100}%");
                            }
                        }
                    }
                    else
                    {
                        // Get more Examples
                        File.Copy(image[i], @"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha\" + $"{GetRandomString(10)}.png");
                    }
                }
                else
                {
                    // Must be the candy cane
                    if (captcha == "Candy Cane")
                    {
                        // Correct Answer
                        predictedIndex = i;
                        bestAcc = 100;
                    }
                    try
                    {
                        File.Delete(@"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha_temp\generate_image.gif");
                    }
                    catch
                    {

                    }
                }
            }

            if (predictedIndex >= 0) // Found something
            {
                browser.EvaluateScriptAsync($"document.getElementsByClassName('text-center bg-white rounded-md p-4 cursor-pointer')[{predictedIndex}].click();" +
                                            "console.log('[>] Captcha solved');"
                                            );
            }
            captcha_log = "";
            for (int i = 0; i < image.Length; i++)
            {
                try
                {
                    File.Delete(@"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha_temp\" + i + ".png");
                }
                catch
                {

                }
                
            }
            // document.getElementsByClassName('text-center bg-white rounded-md p-4 cursor-pointer')[3];
        }

        private void Bot()
        {
            while (true)
            {
                // Somehow checking if the address contains something, still returns a not initialized object exception
                if (!String.IsNullOrEmpty(browser.Address))
                {
                    Thread.Sleep(1000);
                    if (browser.Address == "https://web.simple-mmo.com/travel")
                    {
                        performStep();
                    }
                    else if (browser.Address == "https://web.simple-mmo.com/i-am-not-a-bot")
                    {
                        solveCaptcha();
                        browser.Reload();
                    }
                    else
                    {
                        performAttack();
                    }
                }
                
                /*if (browser.Address == "https://web.simple-mmo.com/i-am-not-a-bot")
                {
                    var looking_for = document.getElementsByClassName('text-2xl text-gray-800 font-semibold')[0];
                    var looking_for_text = looking_for.textContent;

                }*/
        }
    }

        private void captcha_page_button_Click(object sender, EventArgs e)
        {
            browser.LoadUrlAsync("https://web.simple-mmo.com/i-am-not-a-bot");
        }

        private void travel_page_button_Click(object sender, EventArgs e)
        {
            browser.LoadUrlAsync("https://web.simple-mmo.com/travel");
        }
    }

    class MyCustomDownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            if (downloadItem.IsValid)
            {
                Console.WriteLine("== File information ========================");
                Console.WriteLine(" File URL: {0}", downloadItem.Url);
                Console.WriteLine(" Suggested FileName: {0}", downloadItem.SuggestedFileName);
                Console.WriteLine(" MimeType: {0}", downloadItem.MimeType);
                Console.WriteLine(" Content Disposition: {0}", downloadItem.ContentDisposition);
                Console.WriteLine(" Total Size: {0}", downloadItem.TotalBytes);
                Console.WriteLine("============================================");
            }

            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    // Define the Downloads Directory Path
                    // You can use a different one, in this example we will hard-code it
                    string DownloadsDirectoryPath = @"C:\Users\breit\source\repos\SMMOB\SMMOB\assets\captcha_temp";

                    callback.Continue(
                        Path.Combine(
                            DownloadsDirectoryPath,
                            downloadItem.SuggestedFileName
                        ),
                        showDialog: false
                    );
                }
            }
        }

        /// https://cefsharp.github.io/api/51.0.0/html/T_CefSharp_DownloadItem.htm
        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);

            if (downloadItem.IsValid)
            {
                // Show progress of the download
                if (downloadItem.IsInProgress && (downloadItem.PercentComplete != 0))
                {
                    Console.WriteLine(
                        "Current Download Speed: {0} bytes ({1}%)",
                        downloadItem.CurrentSpeed,
                        downloadItem.PercentComplete
                    );
                }

                if (downloadItem.IsComplete)
                {
                    Console.WriteLine("The download has been finished !");
                }
            }
        }
    }
}
