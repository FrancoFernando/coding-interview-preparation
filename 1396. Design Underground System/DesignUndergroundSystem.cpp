class UndergroundSystem {
    
    using pii = pair<int,int>;
    using pis = pair<int,string>;
    
    unordered_map<int,pis> idToStation;
    unordered_map<string,pii> stationToTime;
    
public:
    UndergroundSystem() {
        
    }
    
    void checkIn(int id, string stationName, int t) {
        idToStation[id] = make_pair(t,stationName);
    }
    
    void checkOut(int id, string stationName, int t) {
        
        int checkInTime;
        string checkInStation;
        tie(checkInTime,checkInStation) = idToStation[id];
        
        int travelTime = t - checkInTime;
        string comboStations = checkInStation+stationName;
        
        stationToTime[comboStations].first += travelTime;
        stationToTime[comboStations].second++;
        
        idToStation.erase(id);
    }
    
    double getAverageTime(string startStation, string endStation) {
        
        string comboStations = startStation+endStation;
        double travelTime, nTravels;
        tie(travelTime, nTravels) = stationToTime[comboStations];
        return travelTime/nTravels;
    }
};

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem* obj = new UndergroundSystem();
 * obj->checkIn(id,stationName,t);
 * obj->checkOut(id,stationName,t);
 * double param_3 = obj->getAverageTime(startStation,endStation);
 */