using System.Text;
namespace actionlib_msgs.msg
{


[System.Serializable]
public class GoalID : Halodi.CDR.DataType<GoalID>
{

	public Halodi.CDR.TopicDataType<GoalID> Type => new GoalIDPubSubType();
	
   /**
            * The stamp should store the time at which this goal was requested.
            * It is used by an action server when it tries to preempt all
            * goals that were requested before a certain time
            */
   public builtin_interfaces.msg.Time stamp;
   /**
            * The id provides a way to associate feedback and
            * result message with specific goal requests. The id
            * specified must be unique.
            */
   public string id;


   public void Set(GoalID other)
   {
      builtin_interfaces.msg.TimePubSubType.Copy(other.stamp, stamp);

      id = other.id;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("GoalID {");
      builder.Append("stamp=");
      builder.Append(this.stamp);      builder.Append(", ");
      builder.Append("id=");
      builder.Append(this.id);
      builder.Append("}");
      return builder.ToString();
   }
}


}