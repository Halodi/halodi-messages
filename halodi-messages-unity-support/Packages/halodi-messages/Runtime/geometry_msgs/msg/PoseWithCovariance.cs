using System.Text;
namespace geometry_msgs.msg
{


/**
       * This represents a pose in free space with uncertainty.
       */
[System.Serializable]
public class PoseWithCovariance
{
   public geometry_msgs.msg.Pose pose;
   /**
            * Row-major representation of the 6x6 covariance matrix
            * The orientation parameters use a fixed-axis representation.
            * In order, the parameters are:
            * (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)
            */
   public readonly double[] covariance = new double[36];


   public void Set(PoseWithCovariance other)
   {
      geometry_msgs.msg.PosePubSubType.Copy(other.pose, pose);

      for(int i1 = 0; i1 < 36; ++i1)
      {
            covariance[i1] = other.covariance[i1];

      }

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PoseWithCovariance {");
      builder.Append("pose=");
      builder.Append(this.pose);      builder.Append(", ");
      builder.Append("covariance=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.covariance));
      builder.Append("}");
      return builder.ToString();
   }
}


}