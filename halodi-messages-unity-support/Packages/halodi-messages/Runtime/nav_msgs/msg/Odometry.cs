using System.Text;
namespace nav_msgs.msg
{


/**
       * This represents an estimate of a position and velocity in free space.
       * The pose in this message should be specified in the coordinate frame given by header.frame_id
       * The twist in this message should be specified in the coordinate frame given by the child_frame_id
       */
[System.Serializable]
public class Odometry : Halodi.CDR.DataType<Odometry>
{

	public Halodi.CDR.TopicDataType<Odometry> Type => new OdometryPubSubType();
	
   public std_msgs.msg.Header header;
   public string child_frame_id;
   public geometry_msgs.msg.PoseWithCovariance pose;
   public geometry_msgs.msg.TwistWithCovariance twist;


   public void Set(Odometry other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      child_frame_id = other.child_frame_id;

      geometry_msgs.msg.PoseWithCovariancePubSubType.Copy(other.pose, pose);

      geometry_msgs.msg.TwistWithCovariancePubSubType.Copy(other.twist, twist);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Odometry {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("child_frame_id=");
      builder.Append(this.child_frame_id);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("twist=");
      builder.Append(this.twist);
      builder.Append("}");
      return builder.ToString();
   }
}


}