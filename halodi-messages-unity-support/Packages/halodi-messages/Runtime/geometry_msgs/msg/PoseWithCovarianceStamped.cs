using System.Text;
namespace geometry_msgs.msg
{


/**
       * This expresses an estimated pose with a reference coordinate frame and timestamp
       */
[System.Serializable]
public class PoseWithCovarianceStamped : Halodi.CDR.DataType<PoseWithCovarianceStamped>
{

	public Halodi.CDR.TopicDataType<PoseWithCovarianceStamped> Type => new PoseWithCovarianceStampedPubSubType();
	
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.PoseWithCovariance pose;


   public void Set(PoseWithCovarianceStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.PoseWithCovariancePubSubType.Copy(other.pose, pose);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PoseWithCovarianceStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);
      builder.Append("}");
      return builder.ToString();
   }
}


}