# Thinking Process 

1. Checkin and check out are independent so we need to save checkin data to be retrieved at checkout time. Both time and station name needs to be saved -> hash map id to info. At check out we need to update data for ansering average time between two station, so we compute travel time and add it to the total travel time between src and dst station -> hash map stations to time. Also the number of travels between the station is necessary for the average.

# Take aways

* Do not forget int / int generate int in c++, convert first to double.

# Complexity (approach 1)

* O(1) time, if we exclude the string combination operation.
* O(N+M^2) space where N is number of passengers (ids) and M number of station (M^2 combinations).






