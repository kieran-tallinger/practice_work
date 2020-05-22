public class Program {
    public static string MissingAngle(int angle1, int angle2) {
        string angle3;
        if (angle1 + angle2 < 89) {
            angle3 = "obtuse";
            return angle3;
        } else if (angle1 + angle2 == 90) {
            angle3 = "right";
            return angle3;
        } else {
            angle3 = "acute";
            return angle3;
        }
    }
}
