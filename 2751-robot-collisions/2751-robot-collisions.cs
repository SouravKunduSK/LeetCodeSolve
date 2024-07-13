public class Solution {
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) {
    int n = positions.Length;
    var robots = new List<(int pos, int health, char dir, int index)>();

    for (int i = 0; i < n; i++) {
        robots.Add((positions[i], healths[i], directions[i], i));
    }

    
    robots.Sort((a, b) => a.pos.CompareTo(b.pos));

    var stack = new Stack<(int health, char dir, int index)>();

    for (int i = 0; i < robots.Count; i++) {
        var robot = robots[i];

        if (robot.dir == 'R') {
            stack.Push((robot.health, robot.dir, robot.index));
        } else {
           
            while (stack.Count > 0 && stack.Peek().dir == 'R' && robot.health > 0) {
                var top = stack.Pop();

                if (top.health > robot.health) {
                    top.health--;
                    stack.Push(top);
                    robot.health = 0;
                } else if (top.health < robot.health) {
                    robot.health--;
                } else {
                    robot.health = 0;
                }
            }
            if (robot.health > 0) {
                stack.Push((robot.health, robot.dir, robot.index));
            }
        }
    }

  
    var result = new List<int>();
    var survivors = stack.OrderBy(r => r.index).ToList();
    foreach (var survivor in survivors) {
        result.Add(survivor.health);
    }

    return result;
    }
}