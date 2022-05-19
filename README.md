# ASSESSMENT 2: ARRAYS, COLLECTIONS, TRY-CATCHES
### OVERVIEW
Clone the github repo created when you accept the assignment. In the real deal, you will not be graded on what’s in your Main method, though you are encouraged to test your code as you write it.

### BUILD SPECIFICATIONS
The assessment is worth ten points, one for each of the test cases below. Pay special attention to the items in bold. You must use these in your program exactly, including capitalization, in order to get the points.

1. Create a static method named AddStarWarsCharacters() that takes in a string[].
 This method then searches for and returns the index of “Yoda”.
- If “Yoda” is not in the array, return -1.
2. Create a static method named DeathStarCombat() that takes in a Dictionary<string,int> of Star Wars characters (key) and their attack values (value)
- This method should return the name of the Jedi with the highest Attack value.
3. Create a static method named ConvertPlanets() takes in one parameter: an array of planets
- The method will convert the array of planets into a list of planets in the reverse order.
- Return List.
4. Create a static method named AverageDroids() takes in an integer List for droids
- The method will search through the list and calculate the average of all even-numbered droids. 
- Return average.
- Hint: Create another list to store the even numbers in. What do you think an average will return?
5. Create a static method named TryToCatchDarthVader(). This method will take in a string as a parameter and parse that string as an integer.
- return “Vader Was Captured!” If the parse is successful.
- return “Vader Got Away!”. If FormatException is thrown. 
- Hint: Use A Try-Catch.
