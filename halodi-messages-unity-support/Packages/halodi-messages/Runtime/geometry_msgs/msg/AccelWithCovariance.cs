using System.Text;
namespace geometry_msgs.msg
{


/**
       * This expresses acceleration in free space with uncertainty.
       */
[System.Serializable]
public class AccelWithCovariance : Halodi.CDR.DataType<AccelWithCovariance>
{

	public Halodi.CDR.TopicDataType<AccelWithCovariance> Type => new AccelWithCovariancePubSubType();
	
   public geometry_msgs.msg.Accel accel;
   /**
            * Row-major representation of the 6x6 covariance matrix
            * The orientation parameters use a fixed-axis representation.
            * In order, the parameters are:
            * (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)
            */
   public double[] covariance = new double[36];


   public void Set(AccelWithCovariance other)
   {
      geometry_msgs.msg.AccelPubSubType.Copy(other.accel, accel);

      for(int i1 = 0; i1 < 36; ++i1)
      {
            covariance[i1] = other.covariance[i1];

      }

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("AccelWithCovariance {");
      builder.Append("accel=");
      builder.Append(this.accel);      builder.Append(", ");
      builder.Append("covariance=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.covariance));
      builder.Append("}");
      return builder.ToString();
   }
}


}