/* Write your T-SQL query statement below */
SELECT a.id FROM Weather a, Weather b
WHERE a.recordDate > b.recordDate AND datediff(DAY,a.recordDate,b.recordDate) = -1 AND  a.temperature > b.temperature 