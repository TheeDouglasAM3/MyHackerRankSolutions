using System;
using System.Collections.Generic;
using System.IO;
class Solution {

    static Dictionary<string, string> fillPhoneBook(int qtdPhones){
        var phoneBook = new Dictionary<string, string>();
        for(int i = 0; i < qtdPhones; i++){
            string[] infoPerson = Console.ReadLine().Split(' ');
            phoneBook.Add(infoPerson[0], infoPerson[1]);
        }
        return phoneBook;
    }

    static bool tryFindPhoneBook(Dictionary<string, string> phoneBook, string name){
        return phoneBook.ContainsKey(name);
    }

    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int qtdPhones = Convert.ToInt32(Console.ReadLine());
        
        var phoneBook = fillPhoneBook(qtdPhones);

        string nameToSearch;
        while((nameToSearch = Console.ReadLine()) != null){
            if(tryFindPhoneBook(phoneBook, nameToSearch))
                Console.WriteLine($"{nameToSearch}={phoneBook[nameToSearch]}");
            else
                Console.WriteLine("Not found");
        }
    }
}
