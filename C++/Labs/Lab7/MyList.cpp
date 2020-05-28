#include "MyListNode.cpp"
#include <cstddef>
#include <stdexcept>
class MyList
{
public:
    MyListNode Head;
    int Count;

	void Add(int value)
	{
		if (&Head == NULL)
		{
			Head = MyListNode(value);
			++Count;
			return;
		}
		MyListNode newNode = MyListNode(value);
		newNode.next = Head.next;
		Head.next = &newNode;
		++Count;
	}

	void Delete(int value)
	{
		MyListNode node = FindNode(value);
		if (&node == NULL)
		{
			throw std::logic_error("Not exist node with value");
		}

		if (&node == &Head)
		{
			Head = *node.next;
		}
		else
		{
			MyListNode t = Head;
			while (t.next != &node)
			{
				t = *t.next;
			}

			t.next = node.next;
		}

		--Count;
	}

	MyListNode FindNode(int value)
	{
		MyListNode node = Head;
		while (&node != NULL)
		{
			if (node.item == value)
			{
				return node;
			}

			node = *node.next;
		}

		return NULL;
	}

	void DeleteAfterMax()
	{
		MyListNode max = Max();
		MyListNode node = *max.next;
		while (&node != NULL)
		{
			node = *node.next;
			--Count;
		}

		max.next = NULL;
	}

	MyListNode Max()
	{
		if (&Head == NULL)
		{
			throw std::logic_error("Head node is null");
		}
		MyListNode node = Head;
		MyListNode max = Head;
		while (&node != NULL)
		{
			if (node.item >= max.item)
			{
				max = node;
			}

			node = *node.next;
		}

		return max;
	}

	int FiveKrat()
	{
		if (&Head == NULL)
		{
			throw std::logic_error("Head node is null");
		}
		int counter = 0;
		MyListNode node = Head;
		while (&node != NULL)
		{
			if (node.item % 5 == 0)
			{
				++counter;
			}

			node = *node.next;
		}

		return counter;
	}

};