# Interval Intersections 📏
### Description
Given two sorted lists of intervals, implement a function to find their intersections. An interval [a, b] intersects with another interval [c, d] if there exists a number x such that x lies in both intervals. The intersection of [a, b] and [c, d] is the interval [max(a, c), min(b, d)], provided max(a, c) <= min(b, d).


#### Input:
user1 and user2: Lists of intervals, where each interval is represented as [start, end] (both inclusive).
Each list is sorted by the start of the intervals.
Intervals within a list do not overlap.
#### Output:
A list of intervals representing the intersections of user1 and user2.
