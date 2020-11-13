using System.Text;
namespace geometry_msgs.msg
{


/**
       * This represents an estimated twist with reference coordinate frame and timestamp.
       */
[System.Serializable]
public class TwistWithCovarianceStamped : Halodi.CDR.DataType<TwistWithCovarianceStamped>
{

	public Halodi.CDR.TopicDataType<TwistWithCovarianceStamped> Type => new TwistWithCovarianceStampedPubSubType();
	
   public std_msgs.msg.Header header;
   public geometry_msgs.msg.TwistWithCovariance twist;


   public void Set(TwistWithCovarianceStamped other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.TwistWithCovariancePubSubType.Copy(other.twist, twist);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TwistWithCovarianceStamped {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("twist=");
      builder.Append(this.twist);
      builder.Append("}");
      return builder.ToString();
   }
}


}