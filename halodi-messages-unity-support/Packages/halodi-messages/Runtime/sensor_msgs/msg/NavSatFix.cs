using System.Text;
namespace sensor_msgs.msg
{


/**
       * Navigation Satellite fix for any Global Navigation Satellite System
       * 
       * Specified using the WGS 84 reference ellipsoid
       * If the covariance of the fix is known, fill it in completely. If the
       * GPS receiver provides the variance of each measurement, put them
       * along the diagonal. If only Dilution of Precision is available,
       * estimate an approximate covariance from that.
       */
[System.Serializable]
public class NavSatFix
{
   public const byte COVARIANCE_TYPE_UNKNOWN = (byte) 0;
   public const byte COVARIANCE_TYPE_APPROXIMATED = (byte) 1;
   public const byte COVARIANCE_TYPE_DIAGONAL_KNOWN = (byte) 2;
   public const byte COVARIANCE_TYPE_KNOWN = (byte) 3;
   /**
            * header.stamp specifies the ROS time for this measurement (the
            * corresponding satellite time may be reported using the
            * sensor_msgs/TimeReference message).
            * 
            * header.frame_id is the frame of reference reported by the satellite
            * receiver, usually the location of the antenna.  This is a
            * Euclidean frame relative to the vehicle, not a reference
            * ellipsoid.
            */
   public std_msgs.msg.Header header;
   /**
            * Satellite fix status information.
            */
   public sensor_msgs.msg.NavSatStatus status;
   /**
            * Latitude [degrees]. Positive is north of equator; negative is south.
            */
   public double latitude;
   /**
            * Longitude [degrees]. Positive is east of prime meridian; negative is west.
            */
   public double longitude;
   /**
            * Altitude [m]. Positive is above the WGS 84 ellipsoid
            * (quiet NaN if no altitude is available).
            */
   public double altitude;
   /**
            * Position covariance [m^2] defined relative to a tangential plane
            * through the reported position. The components are East, North, and
            * Up (ENU), in row-major order.
            * 
            * Beware: this coordinate system exhibits singularities at the poles.
            */
   public readonly double[] position_covariance = new double[9];
   public byte position_covariance_type;


   public void Set(NavSatFix other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      sensor_msgs.msg.NavSatStatusPubSubType.Copy(other.status, status);

      latitude = other.latitude;

      longitude = other.longitude;

      altitude = other.altitude;

      for(int i1 = 0; i1 < 9; ++i1)
      {
            position_covariance[i1] = other.position_covariance[i1];

      }

      position_covariance_type = other.position_covariance_type;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("NavSatFix {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("status=");
      builder.Append(this.status);      builder.Append(", ");
      builder.Append("latitude=");
      builder.Append(this.latitude);      builder.Append(", ");
      builder.Append("longitude=");
      builder.Append(this.longitude);      builder.Append(", ");
      builder.Append("altitude=");
      builder.Append(this.altitude);      builder.Append(", ");
      builder.Append("position_covariance=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.position_covariance));      builder.Append(", ");
      builder.Append("position_covariance_type=");
      builder.Append(this.position_covariance_type);
      builder.Append("}");
      return builder.ToString();
   }
}


}