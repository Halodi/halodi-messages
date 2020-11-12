using System.Text;
namespace action_msgs.msg
{


[System.Serializable]
public class GoalInfo
{
   /**
            * Goal ID
            */
   public unique_identifier_msgs.msg.UUID goal_id;
   /**
            * Time when the goal was accepted
            */
   public builtin_interfaces.msg.Time stamp;


   public void Set(GoalInfo other)
   {
      unique_identifier_msgs.msg.UUIDPubSubType.Copy(other.goal_id, goal_id);

      builtin_interfaces.msg.TimePubSubType.Copy(other.stamp, stamp);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("GoalInfo {");
      builder.Append("goal_id=");
      builder.Append(this.goal_id);      builder.Append(", ");
      builder.Append("stamp=");
      builder.Append(this.stamp);
      builder.Append("}");
      return builder.ToString();
   }
}


}