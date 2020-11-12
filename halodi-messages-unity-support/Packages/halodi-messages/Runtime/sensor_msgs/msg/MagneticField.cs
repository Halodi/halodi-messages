using System.Text;
namespace sensor_msgs.msg
{


/**
       * Measurement of the Magnetic Field vector at a specific location.
       * 
       * If the covariance of the measurement is known, it should be filled in.
       * If all you know is the variance of each measurement, e.g. from the datasheet,
       * just put those along the diagonal.
       * A covariance matrix of all zeros will be interpreted as "covariance unknown",
       * and to use the data a covariance will have to be assumed or gotten from some
       * other source.
       * field was measured
       * frame_id is the location and orientation
       * of the field measurement
       * field vector in Tesla
       * If your sensor does not output 3 axes,
       * put NaNs in the components not reported.
       */
[System.Serializable]
public class MagneticField
{
   /**
            * timestamp is the time the
            */
   public std_msgs.msg.Header header;
   /**
            * x, y, and z components of the
            */
   public geometry_msgs.msg.Vector3 magnetic_field;
   /**
            * Row major about x, y, z axes
            */
   public readonly double[] magnetic_field_covariance = new double[9];


   public void Set(MagneticField other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      geometry_msgs.msg.Vector3PubSubType.Copy(other.magnetic_field, magnetic_field);

      for(int i1 = 0; i1 < 9; ++i1)
      {
            magnetic_field_covariance[i1] = other.magnetic_field_covariance[i1];

      }

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MagneticField {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("magnetic_field=");
      builder.Append(this.magnetic_field);      builder.Append(", ");
      builder.Append("magnetic_field_covariance=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.magnetic_field_covariance));
      builder.Append("}");
      return builder.ToString();
   }
}


}