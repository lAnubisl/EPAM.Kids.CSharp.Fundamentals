int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i = i + 1) {
    Console.Write("Enter number " + (i + 1) + ": ");
    numbers[i] = int.Parse(Console.ReadLine());
}

 //732324234
 //    32432

// [7][3][2][3][8][4][2][3][4]
// [0][0][0][0][3][2][4][3][2]
// ---------------------------
// [7][3][2][4][1][6][6][6][6]


// 178 % 10 = 8
// 178 - 8 = 170
// 170 / 10 = 17
// 17 % 10 = 7

// 1 * 8 = 8
// 8 * 10 + 7 = 87

//  for(int i = numbers.Length - 1; i >= 0; i = i - 1) {
//  }





// merge sort
// 1. split the array into two halves
// 2. sort each half
// 3. merge the two halves


//Console.WriteLine("The Max is: " + max);
// for(int i = 0; i < fileNames.Length; i = i + 1)
// {
//     Console.Write("Enter file name " + (i + 1) + ": ");
//     fileNames[i] = Console.ReadLine();
// }



// string[] fileNames = new string[5];

// Console.WriteLine("Array of length " + fileNames.Length + " created.");

// for(int i = 0; i < fileNames.Length; i = i + 1)
// {
//     Console.Write("Enter file name " + (i + 1) + ": ");
//     fileNames[i] = Console.ReadLine();
// }

// foreach(string fileName in fileNames)
// {
//     Console.WriteLine("File name: " + fileName);
// }

// int index = 0;
// while(index < fileNames.Length)
// {
//     Console.WriteLine("File name " + (index + 1) + ": " + fileNames[index]);
//     index = index + 1;
// }

// bool success = false;
// do {
//     Console.Write("Enter file name to search for: ");
//     string searchName = Console.ReadLine();
//     if (searchName == "hello") {
//         success = true;
//     }
// } while(!success);



// Console.WriteLine("Goodbye!");
