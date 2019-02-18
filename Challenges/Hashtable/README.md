# Hashtables
Hashtables are highly efficient data structures comprised of two parts: an associative array and a mapping, or hash, function. A hash function assigns an integer to data which represents its index within the array.

## Challenge
Implement a Hashtable with the following methods:

- Add: takes in both the key and value. This method should hash the key, and add the key and value pair to the table, handling collisions as needed.
- Get: takes in the key and returns the value from the table.
- Contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
- Hash: takes in an arbitrary key and returns an index in the collection.

## Approach & Efficiency
#### Add:
- Time: O(1) to add key value pair to correct index in associative array
- Space: O(1) returning the key integer

#### Get:
- Time: O(1) to get value at index in associative array
- Space: O(1) retrieving a value, not creating anything new

#### Contains:
- Time: O(1) to check if associative array contains a specified index
- Space: O(1) checking if key value pair is present at index, not creating anything new

#### Hash:
- Time: O(1) to take in key and hash to index
- Space: O(1) returning index in associative array
