using System.Text;
namespace lifecycle_msgs.msg
{


/**
       * Primary state definitions
       * as depicted in
       * http://design.ros2.org/articles/node_lifecycle.html
       */
[System.Serializable]
public class State : Halodi.CDR.DataType<State>
{

	public Halodi.CDR.TopicDataType<State> Type => new StatePubSubType();
	
   /**
          * These are the primary states
          * State changes can only be requested
          * when the node is in one of these states.
          */
   public const byte PRIMARY_STATE_UNKNOWN = (byte) 0;
   public const byte PRIMARY_STATE_UNCONFIGURED = (byte) 1;
   public const byte PRIMARY_STATE_INACTIVE = (byte) 2;
   public const byte PRIMARY_STATE_ACTIVE = (byte) 3;
   public const byte PRIMARY_STATE_FINALIZED = (byte) 4;
   /**
          * Temporary intermediate states
          * When a transition is requested, the
          * node changes its state into one
          * of these states.
          */
   public const byte TRANSITION_STATE_CONFIGURING = (byte) 10;
   public const byte TRANSITION_STATE_CLEANINGUP = (byte) 11;
   public const byte TRANSITION_STATE_SHUTTINGDOWN = (byte) 12;
   public const byte TRANSITION_STATE_ACTIVATING = (byte) 13;
   public const byte TRANSITION_STATE_DEACTIVATING = (byte) 14;
   public const byte TRANSITION_STATE_ERRORPROCESSING = (byte) 15;
   public byte id;
   public string label;


   public void Set(State other)
   {
      id = other.id;

      label = other.label;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("State {");
      builder.Append("id=");
      builder.Append(this.id);      builder.Append(", ");
      builder.Append("label=");
      builder.Append(this.label);
      builder.Append("}");
      return builder.ToString();
   }
}


}