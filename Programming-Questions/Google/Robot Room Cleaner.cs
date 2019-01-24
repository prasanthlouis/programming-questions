/**
 * // This is the robot's control interface.
 * // You should not implement it, or speculate about its implementation
 * interface Robot {
 *     // Returns true if the cell in front is open and robot moves into the cell.
 *     // Returns false if the cell in front is blocked and robot stays in the current cell.
 *     public bool Move();
 *
 *     // Robot will stay in the same cell after calling turnLeft/turnRight.
 *     // Each turn will be 90 degrees.
 *     public void TurnLeft();
 *     public void TurnRight();
 *
 *     // Clean the current cell.
 *     public void Clean();
 * }
 */
class Solution {
    List<Coords> list = new List<Coords>{
        new Coords(1,0),
        new Coords(0,-1),
        new Coords(-1, 0),
        new Coords(0, 1)
    };
    public void CleanRoom(Robot robot) {
        var dict = new Dictionary<string, int>();
        Recurse(robot, 0, 0, 0, dict);
    }
    
    public void Recurse(Robot robot, int x, int y, int curDir, Dictionary<string, int> dict)
    {
        robot.Clean();
        var currentSpace = $"{x},{y}";

        dict.Add(currentSpace, 1);

        for(int i = 0 ; i < 4 ; i++)
        {
            var dir = (curDir + i) % 4;
            var dx = x + list[dir].x;
            var dy = y + list[dir].y;
            Console.WriteLine($"{dx},{dy}");
            if(!dict.ContainsKey($"{dx},{dy}") && robot.Move())
            {
                Recurse(robot, dx, dy, dir, dict);
                robot.TurnRight();
                robot.TurnRight();
                robot.Move();
                robot.TurnRight();
                robot.TurnRight();
            }
            
            robot.TurnRight();
        }
        
    }
}
                                      
public class Coords{
    public Coords(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int x;
    public int y;
}
