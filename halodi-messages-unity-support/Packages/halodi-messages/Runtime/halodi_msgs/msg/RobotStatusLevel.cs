using System.Text;
namespace halodi_msgs.msg
{


/**
         * Status level of the robot
         */
[System.Serializable]
public class RobotStatusLevel : Halodi.CDR.DataType<RobotStatusLevel>
{

	public Halodi.CDR.TopicDataType<RobotStatusLevel> Type => new RobotStatusLevelPubSubType();
	
   /**
                 * Robot is in normal status
                 */
   public const byte OK = (byte) 0;
   /**
                *  A warning has been detected. The user can resolve the warning and continue operation
                */
   public const byte WARN = (byte) 1;
   /**
                * A non-recoverable error has been detected. The robot can continue operation with reduced functionality
                */
   public const byte ERROR = (byte) 2;
   /**
                * A critical error has been detected. The robot will shutdown immediatly
                */
   public const byte CRITICAL = (byte) 3;
   public byte level;


   public void Set(RobotStatusLevel other)
   {
      level = other.level;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("RobotStatusLevel {");
      builder.Append("level=");
      builder.Append(this.level);
      builder.Append("}");
      return builder.ToString();
   }
}


}