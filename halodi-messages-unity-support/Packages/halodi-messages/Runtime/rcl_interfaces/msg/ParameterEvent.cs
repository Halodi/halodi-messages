using System.Text;
namespace rcl_interfaces.msg
{


/**
       * This message contains a parameter event.
       * It was an atomic update.
       * A specific parameter name can only be in one of the three sets.
       */
[System.Serializable]
public class ParameterEvent : Halodi.CDR.DataType<ParameterEvent>
{

	public Halodi.CDR.TopicDataType<ParameterEvent> Type => new ParameterEventPubSubType();
	
   public builtin_interfaces.msg.Time stamp;
   /**
            * Fully qualified ROS path to node
            */
   public string node;
   public System.Collections.Generic.List<rcl_interfaces.msg.Parameter> new_parameters;
   public System.Collections.Generic.List<rcl_interfaces.msg.Parameter> changed_parameters;
   public System.Collections.Generic.List<rcl_interfaces.msg.Parameter> deleted_parameters;


   public void Set(ParameterEvent other)
   {
      builtin_interfaces.msg.TimePubSubType.Copy(other.stamp, stamp);

      node = other.node;


      if(other.new_parameters == null)
      {
      	new_parameters = null;
      }
      else
      {
      	new_parameters = new System.Collections.Generic.List<rcl_interfaces.msg.Parameter>(other.new_parameters.Count);
      	for(int i1 = 0; i1 < other.new_parameters.Count; i1++)
      	{
      		if(other.new_parameters[i1] == null)
      		{
      			new_parameters.Add(null);
      		}
      		else
      		{
      			rcl_interfaces.msg.Parameter newElement = rcl_interfaces.msg.ParameterPubSubType.Create();
      	   		rcl_interfaces.msg.ParameterPubSubType.Copy(other.new_parameters[i1], newElement);
      	   		new_parameters.Add(newElement);
      		}	}
      }

      if(other.changed_parameters == null)
      {
      	changed_parameters = null;
      }
      else
      {
      	changed_parameters = new System.Collections.Generic.List<rcl_interfaces.msg.Parameter>(other.changed_parameters.Count);
      	for(int i2 = 0; i2 < other.changed_parameters.Count; i2++)
      	{
      		if(other.changed_parameters[i2] == null)
      		{
      			changed_parameters.Add(null);
      		}
      		else
      		{
      			rcl_interfaces.msg.Parameter newElement = rcl_interfaces.msg.ParameterPubSubType.Create();
      	   		rcl_interfaces.msg.ParameterPubSubType.Copy(other.changed_parameters[i2], newElement);
      	   		changed_parameters.Add(newElement);
      		}	}
      }

      if(other.deleted_parameters == null)
      {
      	deleted_parameters = null;
      }
      else
      {
      	deleted_parameters = new System.Collections.Generic.List<rcl_interfaces.msg.Parameter>(other.deleted_parameters.Count);
      	for(int i3 = 0; i3 < other.deleted_parameters.Count; i3++)
      	{
      		if(other.deleted_parameters[i3] == null)
      		{
      			deleted_parameters.Add(null);
      		}
      		else
      		{
      			rcl_interfaces.msg.Parameter newElement = rcl_interfaces.msg.ParameterPubSubType.Create();
      	   		rcl_interfaces.msg.ParameterPubSubType.Copy(other.deleted_parameters[i3], newElement);
      	   		deleted_parameters.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ParameterEvent {");
      builder.Append("stamp=");
      builder.Append(this.stamp);      builder.Append(", ");
      builder.Append("node=");
      builder.Append(this.node);      builder.Append(", ");
      builder.Append("new_parameters=");
      builder.Append(this.new_parameters);      builder.Append(", ");
      builder.Append("changed_parameters=");
      builder.Append(this.changed_parameters);      builder.Append(", ");
      builder.Append("deleted_parameters=");
      builder.Append(this.deleted_parameters);
      builder.Append("}");
      return builder.ToString();
   }
}


}