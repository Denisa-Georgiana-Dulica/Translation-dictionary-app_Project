# Translation Dictionary
The classes needed to implement the application are CarteTipDictionar, Cuvant, Dictionar together with an ICautare interface created by me. Classes implement ICloneable and IComparable interfaces, have constructors, processing methods, one-dimensional array, operator overloading and properties. 
Behind the application the "dictionary" is based on a database.
Interfaces:
# Form1- in the main interface we find several buttons such as:
1. printing the dictionary
2. selecting a letter to search for a word
3. function of inserting a new word in the dictionary
4. update function of a word from the dictionary including validations
5. function to delete a word from the dictionary
6. display verbs
7. display adjectives
8. display words in DataGridView according to the length of the word
8. the "See suggestions" function to see other dictionary options from stores
9. graphic based on words that have a certain number of meanings.
10.exit button from the application
![Captură de ecran 2024-10-08 225635](https://github.com/user-attachments/assets/e9976669-bc78-4761-8c89-0d0fec306e93)

# Form2
When we click on a word from DataGrigView (Form1), this Form2 will open that shows the meanings of the selected word and other specifications such as the English translation, synonyms, word type, etc. (using data binding).
![Captură de ecran 2024-10-08 225647](https://github.com/user-attachments/assets/fd785a9d-1371-4c17-8e14-f6fe17943e86)

# Form3
1.When you click on the "See suggestions" button in Form1, Form3 will open in which you will find a ListBox with certain dictionaries that we can find on online sites; 
2.The books can be ordered according to price and when selecting a dictionary from the ListBox, the websites from which it can be bought will be displayed in a ComboBox;
3.When selecting a certain site, the price of that dictionary will be displayed in a TextBox and in another TextBox other dictionaries that can be found on that site;
4.When selecting a dictionary from the ListBox, you can click on the "MyWishList" menu and on the "Save wishlist" option you can save that option in a text file;
5.In the same way, you can see the wishlist by selecting the "View wishlist" menu option, which restores the data in a ListView;
6.At the end, the total price is automatically calculated for all the books in the wishlist.
Note: all data with suggested dictionaries, sites, authors, library can be found in the XML file;
![Captură de ecran 2024-10-08 225701](https://github.com/user-attachments/assets/9155475b-566b-4fc3-8971-574a667c54c2)

# Form4
1.All insertion, update and deletion operations take place if you click on the update/insert/delete buttons in Form1 and click on the word header in DataGridView.
Note: the database will also update;
2.To insert a word, the user will have to enter the data in TextaBoxuri and click on the "Insert" button;
3.For updating, certain fields of the chosen word cannot be updated (eg: id, chapter);
4.To delete a word the first time, the user must choose from a ComboBox the specific meaning of the word he wants to delete;
5.There are buttons to add/delete a synonym for a word;
![Captură de ecran 2024-10-08 225711](https://github.com/user-attachments/assets/502f893d-4624-474d-9a00-11ef1cd7a485)

# Form5
Form5 can be reached by clicking on the "Graph" button in Form1. 
1.Here, depending on the changes made to the dictionary, from the menu you must use the function of saving new data in a text file by "Save data in text file";
2.To see the data in a ListView, use the option "See the data from the text file" from the menu;
3.There is a pie chart;
4.There is Graph (using panel);
5.Graphic printing;
![Captură de ecran 2024-10-08 225752](https://github.com/user-attachments/assets/5ca65765-2b52-4f6c-b4aa-308e0bc651dd)
![Captură de ecran 2024-10-08 225744](https://github.com/user-attachments/assets/4301fbda-ba43-4b5f-8073-f4b5bd4f05c1)
