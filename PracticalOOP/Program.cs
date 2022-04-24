// See https://aka.ms/new-console-template for more information
using PracticalOOP.Srp;

var data = new int[][]{
    new int[] { 10, 10 },
    new int[] { 20, 20 },
    new int[] { 30, 30 }
};

var obsucuring = new ObsucuringReference(data);
Array.ForEach(obsucuring.Diameters(), new Action<int>((i) => Console.WriteLine(i)));

var revealing = new RevealingReferences(data);
Array.ForEach(obsucuring.Diameters(), new Action<int>((i) => Console.WriteLine(i)));