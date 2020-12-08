using System.Text;
namespace geometry_msgs.msg
{


[System.Serializable]
public class AccelWithCovarianceStamped : Halodi.CDR.DataType<AccelWithCovarianceStamped>
{

	public Halodi.CDR.TopicDataType<AccelWithCovarianceStamped> Type => new AccelWithCovarianceStampedPubSubType();
	
   /**
            * This represents an estimated accel with reference coordinate frame and timestamp.
            */
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.AccelWithCovariance accel;


   public void Set(AccelWithCovarianceStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.AccelWithCovariancePubSubType.Copy(other.accel, accel);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("AccelWithCovarianceStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("accel=");
      builder.Append(this.accel);
      builder.Append("}");
      return builder.ToString();
   }
}


}