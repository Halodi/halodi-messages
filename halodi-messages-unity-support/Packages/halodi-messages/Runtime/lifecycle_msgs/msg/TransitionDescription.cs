using System.Text;
namespace lifecycle_msgs.msg
{


[System.Serializable]
public class TransitionDescription
{
   public lifecycle_msgs.msg.Transition transition;
   public lifecycle_msgs.msg.State start_state;
   public lifecycle_msgs.msg.State goal_state;


   public void Set(TransitionDescription other)
   {
      lifecycle_msgs.msg.TransitionPubSubType.Copy(other.transition, transition);

      lifecycle_msgs.msg.StatePubSubType.Copy(other.start_state, start_state);

      lifecycle_msgs.msg.StatePubSubType.Copy(other.goal_state, goal_state);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("TransitionDescription {");
      builder.Append("transition=");
      builder.Append(this.transition);      builder.Append(", ");
      builder.Append("start_state=");
      builder.Append(this.start_state);      builder.Append(", ");
      builder.Append("goal_state=");
      builder.Append(this.goal_state);
      builder.Append("}");
      return builder.ToString();
   }
}


}