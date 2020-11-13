using System.Text;
namespace halodi_msgs.msg
{


/**
          * Direct measurement of IMU data for the robot.
          *
          */
[System.Serializable]
public class ImuMeasurement : Halodi.CDR.DataType<ImuMeasurement>
{

	public Halodi.CDR.TopicDataType<ImuMeasurement> Type => new ImuMeasurementPubSubType();
	
   public halodi_msgs.msg.ImuName imu;
   public geometry_msgs.msg.Quaternion orientation;
   public geometry_msgs.msg.Vector3 angular_velocity;
   public geometry_msgs.msg.Vector3 linear_acceleration;


   public void Set(ImuMeasurement other)
   {
      halodi_msgs.msg.ImuNamePubSubType.Copy(other.imu, imu);

      geometry_msgs.msg.QuaternionPubSubType.Copy(other.orientation, orientation);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_velocity, angular_velocity);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_acceleration, linear_acceleration);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ImuMeasurement {");
      builder.Append("imu=");
      builder.Append(this.imu);      builder.Append(", ");
      builder.Append("orientation=");
      builder.Append(this.orientation);      builder.Append(", ");
      builder.Append("angular_velocity=");
      builder.Append(this.angular_velocity);      builder.Append(", ");
      builder.Append("linear_acceleration=");
      builder.Append(this.linear_acceleration);
      builder.Append("}");
      return builder.ToString();
   }
}


}