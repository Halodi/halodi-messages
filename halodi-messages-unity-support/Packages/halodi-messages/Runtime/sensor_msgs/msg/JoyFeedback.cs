using System.Text;
namespace sensor_msgs.msg
{


[System.Serializable]
public class JoyFeedback
{
   /**
          * Declare of the type of feedback
          */
   public const byte TYPE_LED = (byte) 0;
   public const byte TYPE_RUMBLE = (byte) 1;
   public const byte TYPE_BUZZER = (byte) 2;
   public byte type;
   /**
            * This will hold an id number for each type of each feedback.
            * Example, the first led would be id=0, the second would be id=1
            */
   public byte id;
   /**
            * Intensity of the feedback, from 0.0 to 1.0, inclusive.  If device is
            * actually binary, driver should treat 0<=x<0.5 as off, 0.5<=x<=1 as on.
            */
   public float intensity;


   public void Set(JoyFeedback other)
   {
      type = other.type;

      id = other.id;

      intensity = other.intensity;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JoyFeedback {");
      builder.Append("type=");
      builder.Append(this.type);      builder.Append(", ");
      builder.Append("id=");
      builder.Append(this.id);      builder.Append(", ");
      builder.Append("intensity=");
      builder.Append(this.intensity);
      builder.Append("}");
      return builder.ToString();
   }
}


}