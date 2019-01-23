# Stacks and Queues
- A stack is a data structure that consists of Nodes. Each Node references the next node in the stack, but does not reference it’s previous.
- A queue is a data structure that also consists of Nodes. Each Node references the nodes in front and in rear of itself.

## Challenge
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.
- Create a Stack class that has a top property. This object should be aware of a default empty value assigned to top.
- Define a method called push, a method called pop, and a method called peek.
- Create a Queue class that has a front propety and a rear property.
- For the Queue class, create a enqueue method, dequeue method and a peek method.

## Approach & Efficiency
### Stack:
- Push:
	- Time = O(1)
	- Space = O(n)
- Pop:
	- Time = O(1)
	- Space = O(1)
- Peek:
	- Time = O(n)

### Queue:
- Enqueue:
	- Time = O(1)
	- Space = O(1)
- Dequeue:
	- Time = O(1)
	- Space = O(1)
- Peek:	
	- Time = O(1)


## API
### Stack:
- Push: takes any value as an argument and adds a new node with that value to the top of the stack
- Pop:  removes the node from the top of the stack, and returns the node’s value.
- Peek: returns the value of the node located on the top of the stack

### Queue:
- Enqueue:	takes any value as an argument and adds a new node with that value to the back of the queue
- Dequeue:	removes the node from the front of the queue, and returns the node’s value
- Peek:		returns the value of the node located in the front of the stack
