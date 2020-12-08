using System.Text;
namespace geometry_msgs.msg
{


/**
       * This expresses velocity in free space with uncertainty.
       */
[System.Serializable]
public class TwistWithCovariance : Halodi.CDR.DataType<TwistWithCovariance>
{

	public Halodi.CDR.TopicDataType<TwistWithCovariance> Type => new TwistWithCovariancePubSubType();
	
   public geometry_msgs.msg.Twist twist;
   /**
            * Row-major representation of the 6x6 covariance matrix
            * The orientation parameters use a fixed-axis representation.
            * In order, the parameters are:
            * (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)
            */
   public readonly double[] covariance = new double[36];


   public void Set(TwistWithCovariance other)
   {
      geometry_msgs.msg.TwistPubSubType.Copy(other.twist, twist);

      for(int i1 = 0; i1 < 36; ++i1)
      {
            covariance[i1] = other.covariance[i1];

      }

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TwistWithCovariance {");
      builder.Append("twist=");
      builder.Append(this.twist);      builder.Append(", ");
      builder.Append("covariance=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.covariance));
      builder.Append("}");
      return builder.ToString();
   }
}


}