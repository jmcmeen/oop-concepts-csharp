/*
 * MIT License

Copyright (c) 2021 Grant

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 * */

/*
 * Adapted for .NET 8 from 
 * https://github.com/grantwinney/Surviving-WinForms
 * https://grantwinney.com/using-async-await-and-task-to-keep-the-winforms-ui-more-responsive/
 */

using System.Diagnostics;

namespace AsyncAwait
{
    public class BreakfastHeavilyDigested
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly IProgress<string> progress;

        public BreakfastHeavilyDigested(IProgress<string> progress)
        {
            this.progress = progress;
        }

        public async Task MakeBreakfastAsync()
        {
            stopwatch.Start();

            await Task.Run(() =>
            {
                SendMessage("Making breakfast");

                var tasks = new[]
                {
                    Task.Run(() => MakeCoffeeAsync()),
                    Task.Run(() => MakeOrangeJuiceAsync()),
                    Task.Run(() => MakeBreakfastSandwichAsync()),
                };

                Task.WaitAll(tasks);

                NomNomTime();
            });

            stopwatch.Stop();
        }

        /* COFFEE */

        private async Task MakeCoffeeAsync()
        {
            SendMessage("☕ Starting coffee");

            await BrewCoffeeAsync();
            await PourCoffeeAsync();
            await AddMilkAndSugarAsync();

            SendMessage("☕ Finished coffee");
        }

        private async Task BrewCoffeeAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            SendMessage("☕ Coffee brewed");
        }

        private async Task PourCoffeeAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
            });
            SendMessage("☕ Coffee poured");
        }

        private async Task AddMilkAndSugarAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
            });
            SendMessage("☕ Coffee flavored");
        }

        /* ORANGE JUICE */

        private async Task MakeOrangeJuiceAsync()
        {
            SendMessage("🥤 Starting orange juice");

            await Task.Run(() =>
            {
                RemoveJuiceFromFridge();
                PourOrangeJuiceInCup();
            });

            SendMessage("🥤 Finished orange juice");
        }

        private void RemoveJuiceFromFridge()
        {
            Thread.Sleep(500);
            SendMessage("🥤 Got orange juice");
        }

        private void PourOrangeJuiceInCup()
        {
            Thread.Sleep(500);
            SendMessage("🥤 Poured orange juice");
        }

        /* SANDWICH */

        private async Task MakeBreakfastSandwichAsync()
        {
            SendMessage("🥪 Starting breakfast sandwich");

            await Task.Run(() => GetFoodFromFridge());

            var tasks = new[]
            {
                Task.Run(() => CookBaconAsync()),
                Task.Run(() => CookEggsAsync()),
                Task.Run(() => ToastBreadAsync()),
                Task.Run(() => RemoveCheeseFromPackageAsync()),
            };
            Task.WaitAll(tasks);

            await AssembleSandwichAsync();
            await SetFoodOnPlateAsync();

            SendMessage("🥪 Finished breakfast sandwich");
        }

        private void GetFoodFromFridge()
        {
            Thread.Sleep(2000);
            SendMessage("🥪 Got food");
        }

        private async Task CookBaconAsync()
        {
            SendMessage("🥓 Started bacon");

            await Task.Run(() =>
            {
                PlaceBaconInPan();
                FryBacon();
            });

            SendMessage("🥓 Finished bacon");
        }

        private void PlaceBaconInPan()
        {
            Thread.Sleep(500);
            SendMessage("🥓 Placed bacon in pan");
        }

        private void FryBacon()
        {
            Thread.Sleep(1000);
            SendMessage("🥓 Fried bacon");
        }

        private async Task CookEggsAsync()
        {
            SendMessage("🍳 Started eggs");

            await Task.Run(() =>
            {
                CrackEggs();
                PlaceEggsInPan();
                FryEggs();
            });

            SendMessage("🍳 Finished eggs");
        }

        private void CrackEggs()
        {
            Thread.Sleep(1000);
            SendMessage("🍳 Cracked eggs");
        }

        private void PlaceEggsInPan()
        {
            Thread.Sleep(500);
            SendMessage("🍳 Placed eggs in pan");
        }

        private void FryEggs()
        {
            Thread.Sleep(2000);
            SendMessage("🍳 Fried eggs");
        }

        private async Task ToastBreadAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            SendMessage("🍞 Toasted bread");
        }

        private async Task RemoveCheeseFromPackageAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(250);
            });
            SendMessage("🧀 Removed cheese from package");
        }

        private async Task AssembleSandwichAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
            });
            SendMessage("🥪 Assembled sandwich");
        }

        private async Task SetFoodOnPlateAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(500);
            });
            SendMessage("🥪 Placed sandwich on plate");
        }

        /* FINIS! */

        private void NomNomTime()
        {
            SendMessage("🍴 Enjoy!");
        }

        private void SendMessage(string text)
        {
            progress.Report($"[{ stopwatch.ElapsedMilliseconds }] {text}");
        }
    }
}
