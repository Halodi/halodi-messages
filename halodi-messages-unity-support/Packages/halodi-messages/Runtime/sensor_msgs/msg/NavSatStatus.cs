using System.Text;
namespace sensor_msgs.msg
{


/**
       * Navigation Satellite fix status for any Global Navigation Satellite System.
       * 
       * Whether to output an augmented fix is determined by both the fix
       * type and the last time differential corrections were received.  A
       * fix is valid when status >= STATUS_FIX.
       * Bits defining which Global Navigation Satellite System signals were
       * used by the receiver.
       */
[System.Serializable]
public class NavSatStatus
{
   /**
          * unable to fix position
          */
   public const byte STATUS_NO_FIX = (byte) 255;
   /**
          * unaugmented fix
          */
   public const byte STATUS_FIX = (byte) 0;
   /**
          * with satellite-based augmentation
          */
   public const byte STATUS_SBAS_FIX = (byte) 1;
   /**
          * with ground-based augmentation
          */
   public const byte STATUS_GBAS_FIX = (byte) 2;
   public const ushort SERVICE_GPS = 1;
   public const ushort SERVICE_GLONASS = 2;
   /**
          * includes BeiDou.
          */
   public const ushort SERVICE_COMPASS = 4;
   public const ushort SERVICE_GALILEO = 8;
   public byte status;
   public ushort service;


   public void Set(NavSatStatus other)
   {
      status = other.status;

      service = other.service;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("NavSatStatus {");
      builder.Append("status=");
      builder.Append(this.status);      builder.Append(", ");
      builder.Append("service=");
      builder.Append(this.service);
      builder.Append("}");
      return builder.ToString();
   }
}


}