using System.Text;
namespace actionlib_msgs.msg
{


/**
       * be sent over the wire by an action server.
       */
[System.Serializable]
public class GoalStatus : Halodi.CDR.DataType<GoalStatus>
{

	public Halodi.CDR.TopicDataType<GoalStatus> Type => new GoalStatusPubSubType();
	
   /**
          * The goal has yet to be processed by the action server.
          */
   public const byte PENDING = (byte) 0;
   /**
          * The goal is currently being processed by the action server.
          */
   public const byte ACTIVE = (byte) 1;
   /**
          * The goal received a cancel request after it started executing
          */
   public const byte PREEMPTED = (byte) 2;
   /**
          * and has since completed its execution (Terminal State).
          * The goal was achieved successfully by the action server
          */
   public const byte SUCCEEDED = (byte) 3;
   /**
          * (Terminal State).
          * The goal was aborted during execution by the action server due
          */
   public const byte ABORTED = (byte) 4;
   /**
          * to some failure (Terminal State).
          * The goal was rejected by the action server without being processed,
          */
   public const byte REJECTED = (byte) 5;
   /**
          * because the goal was unattainable or invalid (Terminal State).
          * The goal received a cancel request after it started executing
          */
   public const byte PREEMPTING = (byte) 6;
   /**
          * and has not yet completed execution.
          * The goal received a cancel request before it started executing, but
          */
   public const byte RECALLING = (byte) 7;
   /**
          * the action server has not yet confirmed that the goal is canceled.
          * The goal received a cancel request before it started executing
          */
   public const byte RECALLED = (byte) 8;
   /**
          * and was successfully cancelled (Terminal State).
          * An action client can determine that a goal is LOST. This should not
          */
   public const byte LOST = (byte) 9;
   public actionlib_msgs.msg.GoalID goal_id;
   public byte status;
   /**
            * Allow for the user to associate a string with GoalStatus for debugging.
            */
   public string text;


   public void Set(GoalStatus other)
   {
      actionlib_msgs.msg.GoalIDPubSubType.Copy(other.goal_id, goal_id);

      status = other.status;

      text = other.text;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("GoalStatus {");
      builder.Append("goal_id=");
      builder.Append(this.goal_id);      builder.Append(", ");
      builder.Append("status=");
      builder.Append(this.status);      builder.Append(", ");
      builder.Append("text=");
      builder.Append(this.text);
      builder.Append("}");
      return builder.ToString();
   }
}


}