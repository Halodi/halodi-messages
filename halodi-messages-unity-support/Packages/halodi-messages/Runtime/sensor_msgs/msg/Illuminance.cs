using System.Text;
namespace sensor_msgs.msg
{


/**
       * Single photometric illuminance measurement.  Light should be assumed to be
       * measured along the sensor's x-axis (the area of detection is the y-z plane).
       * The illuminance should have a 0 or positive value and be received with
       * the sensor's +X axis pointing toward the light source.
       * 
       * Photometric illuminance is the measure of the human eye's sensitivity of the
       * intensity of light encountering or passing through a surface.
       * 
       * All other Photometric and Radiometric measurements should not use this message.
       * This message cannot represent:
       * - Luminous intensity (candela/light source output)
       * - Luminance (nits/light output per area)
       * - Irradiance (watt/area), etc.
       * frame_id is the location and direction of the reading
       */
[System.Serializable]
public class Illuminance
{
   /**
            * timestamp is the time the illuminance was measured
            */
   public std_msgs.msg.Header header;
   /**
            * Measurement of the Photometric Illuminance in Lux.
            */
   public double illuminance;
   /**
            * 0 is interpreted as variance unknown
            */
   public double variance;


   public void Set(Illuminance other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      illuminance = other.illuminance;

      variance = other.variance;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Illuminance {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("illuminance=");
      builder.Append(this.illuminance);      builder.Append(", ");
      builder.Append("variance=");
      builder.Append(this.variance);
      builder.Append("}");
      return builder.ToString();
   }
}


}