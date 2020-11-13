using System.Text;
namespace action_msgs.msg
{


[System.Serializable]
public class GoalStatus : Halodi.CDR.DataType<GoalStatus>
{

	public Halodi.CDR.TopicDataType<GoalStatus> Type => new GoalStatusPubSubType();
	
   /**
          * An action goal can be in one of these states after it is accepted by an action server.
          * For more information, see http://design.ros2.org/articles/actions.html
          */
   public const byte STATUS_UNKNOWN = (byte) 0;
   public const byte STATUS_ACCEPTED = (byte) 1;
   public const byte STATUS_EXECUTING = (byte) 2;
   public const byte STATUS_CANCELING = (byte) 3;
   public const byte STATUS_SUCCEEDED = (byte) 4;
   public const byte STATUS_CANCELED = (byte) 5;
   public const byte STATUS_ABORTED = (byte) 6;
   /**
            * Goal info (contains ID and timestamp)
            */
   public action_msgs.msg.GoalInfo goal_info;
   /**
            * Goal status
            */
   public byte status;


   public void Set(GoalStatus other)
   {
      action_msgs.msg.GoalInfoPubSubType.Copy(other.goal_info, goal_info);

      status = other.status;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("GoalStatus {");
      builder.Append("goal_info=");
      builder.Append(this.goal_info);      builder.Append(", ");
      builder.Append("status=");
      builder.Append(this.status);
      builder.Append("}");
      return builder.ToString();
   }
}


}