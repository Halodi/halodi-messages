using System.Text;
namespace rcl_interfaces.msg
{


/**
       * This is the message to communicate a parameter's descriptor.
       * Parameter constraints
       * If any of the following sequences are not empty, then the constraint inside of
       * them apply to this parameter.
       */
[System.Serializable]
public class ParameterDescriptor
{
   public string name;
   /**
            * Enum values are defined in the `ParameterType.msg` message.
            */
   public byte type;
   /**
            * Description of the parameter, visible from introspection tools.
            */
   public string description;
   /**
            * Plain English description of additional constraints which cannot be expressed
            * with the available constraints, e.g. "only prime numbers".
            * By convention, this should only be used to clarify constraints which cannot
            * be completely expressed with the parameter constraints below.
            */
   public string additional_constraints;
   /**
            * If 'true' then the value cannot change after it has been initialized.
            */
   public bool read_only;
   /**
            * FloatingPointRange consists of a from_value, a to_value, and a step.
            * FloatingPointRange and IntegerRange are mutually exclusive.
            */
   public System.Collections.Generic.List<rcl_interfaces.msg.FloatingPointRange> floating_point_range;
   /**
            * IntegerRange consists of a from_value, a to_value, and a step.
            * FloatingPointRange and IntegerRange are mutually exclusive.
            */
   public System.Collections.Generic.List<rcl_interfaces.msg.IntegerRange> integer_range;


   public void Set(ParameterDescriptor other)
   {
      name = other.name;

      type = other.type;

      description = other.description;

      additional_constraints = other.additional_constraints;

      read_only = other.read_only;


      if(other.floating_point_range == null)
      {
      	floating_point_range = null;
      }
      else
      {
      	floating_point_range = new System.Collections.Generic.List<rcl_interfaces.msg.FloatingPointRange>(other.floating_point_range.Count);
      	for(int i1 = 0; i1 < other.floating_point_range.Count; i1++)
      	{
      		if(other.floating_point_range[i1] == null)
      		{
      			floating_point_range.Add(null);
      		}
      		else
      		{
      			rcl_interfaces.msg.FloatingPointRange newElement = rcl_interfaces.msg.FloatingPointRangePubSubType.Create();
      	   		rcl_interfaces.msg.FloatingPointRangePubSubType.Copy(other.floating_point_range[i1], newElement);
      	   		floating_point_range.Add(newElement);
      		}	}
      }

      if(other.integer_range == null)
      {
      	integer_range = null;
      }
      else
      {
      	integer_range = new System.Collections.Generic.List<rcl_interfaces.msg.IntegerRange>(other.integer_range.Count);
      	for(int i2 = 0; i2 < other.integer_range.Count; i2++)
      	{
      		if(other.integer_range[i2] == null)
      		{
      			integer_range.Add(null);
      		}
      		else
      		{
      			rcl_interfaces.msg.IntegerRange newElement = rcl_interfaces.msg.IntegerRangePubSubType.Create();
      	   		rcl_interfaces.msg.IntegerRangePubSubType.Copy(other.integer_range[i2], newElement);
      	   		integer_range.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ParameterDescriptor {");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("type=");
      builder.Append(this.type);      builder.Append(", ");
      builder.Append("description=");
      builder.Append(this.description);      builder.Append(", ");
      builder.Append("additional_constraints=");
      builder.Append(this.additional_constraints);      builder.Append(", ");
      builder.Append("read_only=");
      builder.Append(this.read_only);      builder.Append(", ");
      builder.Append("floating_point_range=");
      builder.Append(this.floating_point_range);      builder.Append(", ");
      builder.Append("integer_range=");
      builder.Append(this.integer_range);
      builder.Append("}");
      return builder.ToString();
   }
}


}