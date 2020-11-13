using System.Text;
namespace sensor_msgs.msg
{


/**
       * This is a message to hold data from an IMU (Inertial Measurement Unit)
       * 
       * Accelerations should be in m/s^2 (not in g's), and rotational velocity should be in rad/sec
       * 
       * If the covariance of the measurement is known, it should be filled in (if all you know is the
       * variance of each measurement, e.g. from the datasheet, just put those along the diagonal)
       * A covariance matrix of all zeros will be interpreted as "covariance unknown", and to use the
       * data a covariance will have to be assumed or gotten from some other source
       * 
       * If you have no estimate for one of the data elements (e.g. your IMU doesn't produce an
       * orientation estimate), please set element 0 of the associated covariance matrix to -1
       * If you are interpreting this message, please check for a value of -1 in the first element of each
       * covariance matrix, and disregard the associated estimate.
       */
[System.Serializable]
public class Imu : Halodi.CDR.DataType<Imu>
{

	public Halodi.CDR.TopicDataType<Imu> Type => new ImuPubSubType();
	
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.Quaternion orientation;
   /**
            * Row major about x, y, z axes
            */
   public readonly double[] orientation_covariance = new double[9];
   public geometry_msgs.msg.Vector3 angular_velocity;
   /**
            * Row major about x, y, z axes
            */
   public readonly double[] angular_velocity_covariance = new double[9];
   public geometry_msgs.msg.Vector3 linear_acceleration;
   /**
            * Row major x, y z
            */
   public readonly double[] linear_acceleration_covariance = new double[9];


   public void Set(Imu other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.QuaternionPubSubType.Copy(other.orientation, orientation);

      for(int i1 = 0; i1 < 9; ++i1)
      {
            orientation_covariance[i1] = other.orientation_covariance[i1];

      }

      geometry_msgs.msg.Vector3PubSubType.Copy(other.angular_velocity, angular_velocity);

      for(int i3 = 0; i3 < 9; ++i3)
      {
            angular_velocity_covariance[i3] = other.angular_velocity_covariance[i3];

      }

      geometry_msgs.msg.Vector3PubSubType.Copy(other.linear_acceleration, linear_acceleration);

      for(int i5 = 0; i5 < 9; ++i5)
      {
            linear_acceleration_covariance[i5] = other.linear_acceleration_covariance[i5];

      }

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Imu {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("orientation=");
      builder.Append(this.orientation);      builder.Append(", ");
      builder.Append("orientation_covariance=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.orientation_covariance));      builder.Append(", ");
      builder.Append("angular_velocity=");
      builder.Append(this.angular_velocity);      builder.Append(", ");
      builder.Append("angular_velocity_covariance=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.angular_velocity_covariance));      builder.Append(", ");
      builder.Append("linear_acceleration=");
      builder.Append(this.linear_acceleration);      builder.Append(", ");
      builder.Append("linear_acceleration_covariance=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.linear_acceleration_covariance));
      builder.Append("}");
      return builder.ToString();
   }
}


}