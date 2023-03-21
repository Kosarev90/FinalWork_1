string [] array = {"I", "want", "be", "programmist", "in", "the", "year"};

string[] ThreeSimbolArray(string[] array){

    string[] result = new string[array.Length];

    for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3){
        result[i] = array[i];
    }
}
return result;
}

void ShowArray(string[] array){
    for (int i = 0; i < array.Length; i++){
    Console.Write(array[i] + " ");
}
Console.WriteLine();
}

Console.WriteLine("An array is given string:");
ShowArray(array);
String[] newArray = ThreeSimbolArray(array);
Console.WriteLine("Output length of the string is not more than 3 in the array:");
ShowArray(newArray);