using System.Text;
namespace lifecycle_msgs.msg
{


/**
       * Default values for transitions
       * as described on
       * http://design.ros2.org/articles/node_lifecycle.html
       */
[System.Serializable]
public class Transition
{
   /**
          * Externally available transitions.
          * When a node is in one of these primary states,
          * these transitions can be invoked.
          */
   public const byte TRANSITION_CREATE = (byte) 0;
   public const byte TRANSITION_CONFIGURE = (byte) 1;
   public const byte TRANSITION_CLEANUP = (byte) 2;
   public const byte TRANSITION_ACTIVATE = (byte) 3;
   public const byte TRANSITION_DEACTIVATE = (byte) 4;
   public const byte TRANSITION_UNCONFIGURED_SHUTDOWN = (byte) 5;
   public const byte TRANSITION_INACTIVE_SHUTDOWN = (byte) 6;
   public const byte TRANSITION_ACTIVE_SHUTDOWN = (byte) 7;
   public const byte TRANSITION_DESTROY = (byte) 8;
   /**
          * These transitions are not publically
          * available and cannot be invoked by a user.
          * The following transitions are implicitly
          * invoked based on the callback feedback
          * of the intermediate transition states.
          */
   public const byte TRANSITION_ON_CONFIGURE_SUCCESS = (byte) 10;
   public const byte TRANSITION_ON_CONFIGURE_FAILURE = (byte) 11;
   public const byte TRANSITION_ON_CONFIGURE_ERROR = (byte) 12;
   public const byte TRANSITION_ON_CLEANUP_SUCCESS = (byte) 20;
   public const byte TRANSITION_ON_CLEANUP_FAILURE = (byte) 21;
   public const byte TRANSITION_ON_CLEANUP_ERROR = (byte) 22;
   public const byte TRANSITION_ON_ACTIVATE_SUCCESS = (byte) 30;
   public const byte TRANSITION_ON_ACTIVATE_FAILURE = (byte) 31;
   public const byte TRANSITION_ON_ACTIVATE_ERROR = (byte) 32;
   public const byte TRANSITION_ON_DEACTIVATE_SUCCESS = (byte) 40;
   public const byte TRANSITION_ON_DEACTIVATE_FAILURE = (byte) 41;
   public const byte TRANSITION_ON_DEACTIVATE_ERROR = (byte) 42;
   public const byte TRANSITION_ON_SHUTDOWN_SUCCESS = (byte) 50;
   public const byte TRANSITION_ON_SHUTDOWN_FAILURE = (byte) 51;
   public const byte TRANSITION_ON_SHUTDOWN_ERROR = (byte) 52;
   public const byte TRANSITION_ON_ERROR_SUCCESS = (byte) 60;
   public const byte TRANSITION_ON_ERROR_FAILURE = (byte) 61;
   public const byte TRANSITION_ON_ERROR_ERROR = (byte) 62;
   /**
          * These return values ought to be set
          * as a return value for each callback.
          * Depending on which return value,
          * the transition will be executed correctly
          * or fallback/error callbacks will be triggered.
          */
   public const byte TRANSITION_CALLBACK_SUCCESS = (byte) 97;
   public const byte TRANSITION_CALLBACK_FAILURE = (byte) 98;
   public const byte TRANSITION_CALLBACK_ERROR = (byte) 99;
   public byte id;
   public string label;


   public void Set(Transition other)
   {
      id = other.id;

      label = other.label;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Transition {");
      builder.Append("id=");
      builder.Append(this.id);      builder.Append(", ");
      builder.Append("label=");
      builder.Append(this.label);
      builder.Append("}");
      return builder.ToString();
   }
}


}