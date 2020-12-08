using System.Text;
namespace actionlib_msgs.msg
{


[System.Serializable]
public class GoalStatusArray : Halodi.CDR.DataType<GoalStatusArray>
{

	public Halodi.CDR.TopicDataType<GoalStatusArray> Type => new GoalStatusArrayPubSubType();
	
   /**
            * Stores the statuses for goals that are currently being tracked
            * by an action server
            */
   public std_msgs.msg.Header header;
   public System.Collections.Generic.List<actionlib_msgs.msg.GoalStatus> status_list;


   public void Set(GoalStatusArray other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.status_list == null)
      {
      	status_list = null;
      }
      else
      {
      	status_list = new System.Collections.Generic.List<actionlib_msgs.msg.GoalStatus>(other.status_list.Count);
      	for(int i1 = 0; i1 < other.status_list.Count; i1++)
      	{
      		if(other.status_list[i1] == null)
      		{
      			status_list.Add(null);
      		}
      		else
      		{
      			actionlib_msgs.msg.GoalStatus newElement = actionlib_msgs.msg.GoalStatusPubSubType.Create();
      	   		actionlib_msgs.msg.GoalStatusPubSubType.Copy(other.status_list[i1], newElement);
      	   		status_list.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("GoalStatusArray {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("status_list=");
      builder.Append(this.status_list);
      builder.Append("}");
      return builder.ToString();
   }
}


}