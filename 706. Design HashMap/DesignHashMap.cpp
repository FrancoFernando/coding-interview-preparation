class MyHashMap {
    
    static constexpr int size = 4093;
    vector<list<pair<int,int>>> storage;
    
    int hash (int val) {
        return val % size;
    }
    
public:
    /** Initialize your data structure here. */
    MyHashMap() {
        storage.resize(size);
    }
    
    /** value will always be non-negative. */
    void put(int key, int value) {
        int pos = hash(key);
        for (auto& item : storage[pos]) {
            if (item.first == key) {
                item.second = value;
                return;
            }
        }
        storage[pos].emplace_back(key,value);
    }
    
    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    int get(int key) {
        int pos = hash(key);
        for (auto const& item : storage[pos]) {
            if (item.first == key) {
                return item.second;
            }
        }
        return -1;
    }
    
    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    void remove(int key) {
        int pos = hash(key);
        for (auto it = storage[pos].begin(); it != storage[pos].end(); ++it) {
            if ((*it).first == key) {
                storage[pos].erase(it);
                break;
            }
        }
    }
};

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap* obj = new MyHashMap();
 * obj->put(key,value);
 * int param_2 = obj->get(key);
 * obj->remove(key);
 */