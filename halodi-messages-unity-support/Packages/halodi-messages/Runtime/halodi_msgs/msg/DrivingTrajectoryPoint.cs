using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class DrivingTrajectoryPoint : Halodi.CDR.DataType<DrivingTrajectoryPoint>
{

	public Halodi.CDR.TopicDataType<DrivingTrajectoryPoint> Type => new DrivingTrajectoryPointPubSubType();
	
   public double x;
   public double y;
   public double yaw;
   public double desired_linear_velocity;
   public double desired_angular_velocity;


   public void Set(DrivingTrajectoryPoint other)
   {
      x = other.x;

      y = other.y;

      yaw = other.yaw;

      desired_linear_velocity = other.desired_linear_velocity;

      desired_angular_velocity = other.desired_angular_velocity;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("DrivingTrajectoryPoint {");
      builder.Append("x=");
      builder.Append(this.x);      builder.Append(", ");
      builder.Append("y=");
      builder.Append(this.y);      builder.Append(", ");
      builder.Append("yaw=");
      builder.Append(this.yaw);      builder.Append(", ");
      builder.Append("desired_linear_velocity=");
      builder.Append(this.desired_linear_velocity);      builder.Append(", ");
      builder.Append("desired_angular_velocity=");
      builder.Append(this.desired_angular_velocity);
      builder.Append("}");
      return builder.ToString();
   }
}


}