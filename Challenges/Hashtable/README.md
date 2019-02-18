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

## API
#### Add:
Takes in both the key and value and hashes the key. Adds the key and value pair to the table, handling collisions as needed.

Method:
```
public void Add(string key, string value)
        {
            int hashedKey = Hash(key);
            if (HT[hashedKey] == null)
            {
                HT[hashedKey] = new Node(key, value);
            }
            else
            {
                Node collision = HT[hashedKey];
                while (collision.Next != null)
                {
                    collision = collision.Next;
                }
                collision.Next = new Node(key, value);
            }
        }
```

#### Get:
Takes in the key and returns its value from the table.

Method:
```
public string Get(string key)
        {
            string value = "";
            int hashedKey = Hash(key);
            if (Contains(key) == false)
            {
                return null;
            }
            else if (HT[hashedKey].Key == key)
            {
                value = HT[hashedKey].Value;
            }
            return value;
        }
```

#### Contains:
Takes in a key and returns a true if the key exists in the table already and false if not.

Method:
```
public bool Contains(string key)
        {
            int hashedKey = Hash(key);
            if (HT[hashedKey] == null)
            {
                return false;
            }
            return true;
        }
```

#### Hash:
Takes in an arbitrary key string, converts the each character to an ASCII value, and finds the sum of all characters. The sum is then multiplied by a large prime number (in this case 499), and then the resulting value is divided by the size of the associative array before being returned.

Method:
```
public static int Hash(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += Convert.ToInt32(key[i]);
            }
            index = (index * 499) / HT.Length;
            return index;
        }
```