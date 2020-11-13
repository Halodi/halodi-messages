using System.Text;
namespace halodi_msgs.msg
{


/**
         *
         * Contact point command for the whole body controller
         *
         *
         * Contact points are only valid when the balance mode is set to disabled
         *
         */
[System.Serializable]
public class ContactPointCommand : Halodi.CDR.DataType<ContactPointCommand>
{

	public Halodi.CDR.TopicDataType<ContactPointCommand> Type => new ContactPointCommandPubSubType();
	
   /**
                *
                * Joint to which this contact point is attached. 
                * 
                * Joint that have defined contact points are
                * 
                * KNEE_PITCH       (id 0: knee contact point)
                * ANKLE_ROLL       (id 0: caster)
                * LEFT_WRIST_ROLL  (id 0: left palm)
                * RIGHT_WRIST_ROLL (id 0: right_palm)
                *
                *
                */
   public halodi_msgs.msg.JointName parent_joint;
   /**
                *
                * ID for the contact point for this joint.
                * 
                * Currently, no more than one contact point per joint is defined and
                * contact_point_id is always zero.
                *
                */
   public int contact_point_id;
   /**
                * Define if this point is in contact or not.
                *
                */
   public bool point_in_contact;
   /**
                 * (Optional) normal vector for this contact point
                 *
                 * This vector in expressed in Z-Up world frame.
                 *
                 * If not set, this default to {0,0,1}
                 *
                 */
   public System.Collections.Generic.List<geometry_msgs.msg.Vector3> normal;
   /**
                 * (Optional) coefficient of friction for this contact point
                 *
                 * Recommended range: 0 - 1
                 *
                 * If not set, a reasonable default is choosen`
                 */
   public System.Collections.Generic.List<double> coefficient_of_friction;
   /**
                 * (Optional) Maximum normal contact force
                 *
                 * If not set, the maximum contact force is infinite
                 *
                 * Avoid setting too low, as this will make the controller unstable.
                 */
   public System.Collections.Generic.List<double> maximum_contact_force;
   /**
                  * (Optional) rho weight divider
                  * 
                  * The whole body controller minimizes the contact forces acting on each point. The cost of each contact point is scaled by the "rho weight".
                  * Reducing the rho weight for this contact point would favour this contact point over the others.
                  *
                  * The rho weight divider scales the default controller rho weight. A higher value results in an increased preference for this contact point.
                  * 
                  * Recommended range 0.1 - 10
                  * 
                  * If not set, this defaults to 1.
                  *
                  */
   public System.Collections.Generic.List<double> rho_weight_divider;


   public void Set(ContactPointCommand other)
   {
      halodi_msgs.msg.JointNamePubSubType.Copy(other.parent_joint, parent_joint);

      contact_point_id = other.contact_point_id;

      point_in_contact = other.point_in_contact;


      if(other.normal == null)
      {
      	normal = null;
      }
      else
      {
      	normal = new System.Collections.Generic.List<geometry_msgs.msg.Vector3>(other.normal.Count);
      	for(int i1 = 0; i1 < other.normal.Count; i1++)
      	{
      		if(other.normal[i1] == null)
      		{
      			normal.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Vector3 newElement = geometry_msgs.msg.Vector3PubSubType.Create();
      	   		geometry_msgs.msg.Vector3PubSubType.Copy(other.normal[i1], newElement);
      	   		normal.Add(newElement);
      		}	}
      }

      if(other.coefficient_of_friction == null)
      {
      	coefficient_of_friction = null;
      }
      else
      {
      	coefficient_of_friction = new System.Collections.Generic.List<double>(other.coefficient_of_friction.Count);
      	for(int i2 = 0; i2 < other.coefficient_of_friction.Count; i2++)
      	{
         		coefficient_of_friction.Add(other.coefficient_of_friction[i2]);
      	}
      }

      if(other.maximum_contact_force == null)
      {
      	maximum_contact_force = null;
      }
      else
      {
      	maximum_contact_force = new System.Collections.Generic.List<double>(other.maximum_contact_force.Count);
      	for(int i3 = 0; i3 < other.maximum_contact_force.Count; i3++)
      	{
         		maximum_contact_force.Add(other.maximum_contact_force[i3]);
      	}
      }

      if(other.rho_weight_divider == null)
      {
      	rho_weight_divider = null;
      }
      else
      {
      	rho_weight_divider = new System.Collections.Generic.List<double>(other.rho_weight_divider.Count);
      	for(int i4 = 0; i4 < other.rho_weight_divider.Count; i4++)
      	{
         		rho_weight_divider.Add(other.rho_weight_divider[i4]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ContactPointCommand {");
      builder.Append("parent_joint=");
      builder.Append(this.parent_joint);      builder.Append(", ");
      builder.Append("contact_point_id=");
      builder.Append(this.contact_point_id);      builder.Append(", ");
      builder.Append("point_in_contact=");
      builder.Append(this.point_in_contact);      builder.Append(", ");
      builder.Append("normal=");
      builder.Append(this.normal);      builder.Append(", ");
      builder.Append("coefficient_of_friction=");
      builder.Append(this.coefficient_of_friction);      builder.Append(", ");
      builder.Append("maximum_contact_force=");
      builder.Append(this.maximum_contact_force);      builder.Append(", ");
      builder.Append("rho_weight_divider=");
      builder.Append(this.rho_weight_divider);
      builder.Append("}");
      return builder.ToString();
   }
}


}