/*
 * Below is the interface for Iterator, which is already defined for you.
 * **DO NOT** modify the interface for Iterator.
 *
 *  class Iterator {
 *		struct Data;
 * 		Data* data;
 *		Iterator(const vector<int>& nums);
 * 		Iterator(const Iterator& iter);
 *
 * 		// Returns the next element in the iteration.
 *		int next();
 *
 *		// Returns true if the iteration has more elements.
 *		bool hasNext() const;
 *	};
 */
 
class PeekingIterator : public Iterator {
    
    pair<int, bool> readyToPick;
    
public:
	PeekingIterator(const vector<int>& nums) : Iterator(nums) {
	    // Initialize any member here.
	    // **DO NOT** save a copy of nums and manipulate it directly.
	    // You should only use the Iterator interface methods.
        
        readyToPick = (Iterator::hasNext()) ? make_pair(Iterator::next(), true) : make_pair(-1, false);
	}
	
    // Returns the next element in the iteration without advancing the iterator.
	int peek() {
        //what if no next element
        if (!readyToPick.second) throw std::runtime_error("");
        return readyToPick.first; 
	}
	
	// hasNext() and next() should behave the same as in the Iterator interface.
	// Override them if needed.
	int next() {
        //what if no next element
        if (!readyToPick.second) throw std::runtime_error("");
	    int value = readyToPick.first;
        readyToPick = (Iterator::hasNext()) ? make_pair(Iterator::next(), true) : make_pair(-1, false);
        return value;
	}
	
	bool hasNext() const {
	    return readyToPick.second;
	}
};