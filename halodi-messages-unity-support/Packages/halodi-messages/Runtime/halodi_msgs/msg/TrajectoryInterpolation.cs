using System.Text;
namespace halodi_msgs.msg
{


/**
          *
          * (Emulated) Enum how interpolate this trajectory
          *
          */
[System.Serializable]
public class TrajectoryInterpolation
{
   /**
                 * Use linear interpolation between points
                 * 
                 * Velocity and acceleration targets are ignored. Velocity will be constant.
                 *
                 */
   public const byte LINEAR = (byte) 0;
   /**
                 * Use minimum jerk interplation between points.
                 *
                 * Velocity and acceleration are constrained for every point
                 *
                 *
                 */
   public const byte MINIMUM_JERK_CONSTRAINED = (byte) 1;
   /**
                 *
                 * Use a quintic spline to interpolate over all points.
                 * 
                 * Velocity and acceleration constraints are only considered for the first and last point in this message
                 *
                 */
   public const byte MULTIPLE_WAYPOINT_SPLINE = (byte) 2;
   public byte value;


   public void Set(TrajectoryInterpolation other)
   {
      value = other.value;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TrajectoryInterpolation {");
      builder.Append("value=");
      builder.Append(this.value);
      builder.Append("}");
      return builder.ToString();
   }
}


}