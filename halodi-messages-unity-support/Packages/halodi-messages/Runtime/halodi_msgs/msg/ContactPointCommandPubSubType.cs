using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ContactPointCommand" defined in "ContactPointCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ContactPointCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ContactPointCommand.idl instead.
*
*/
public class ContactPointCommandPubSubType : Halodi.CDR.TopicDataType<ContactPointCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::ContactPointCommand_";


   public static int getCdrSerializedSize(halodi_msgs.msg.ContactPointCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ContactPointCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.JointNamePubSubType.getCdrSerializedSize(data.parent_joint, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.normal.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.normal[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.coefficient_of_friction.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.maximum_contact_force.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.rho_weight_divider.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ContactPointCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.JointNamePubSubType.write(data.parent_joint, cdr);

      cdr.write_type_2(data.contact_point_id);

      cdr.write_type_7(data.point_in_contact);

      	if(data.normal == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int normal_length = data.normal.Count;
            cdr.write_type_2(normal_length);
            for (int i0 = 0; i0 < normal_length; i0++)
            {
      			geometry_msgs.msg.Vector3PubSubType.write(data.normal[i0], cdr);	      }
        }
      	if(data.coefficient_of_friction == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int coefficient_of_friction_length = data.coefficient_of_friction.Count;
            cdr.write_type_2(coefficient_of_friction_length);
            for (int i0 = 0; i0 < coefficient_of_friction_length; i0++)
            {
      			cdr.write_type_6(data.coefficient_of_friction[i0]);
            }
        }
      	if(data.maximum_contact_force == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int maximum_contact_force_length = data.maximum_contact_force.Count;
            cdr.write_type_2(maximum_contact_force_length);
            for (int i0 = 0; i0 < maximum_contact_force_length; i0++)
            {
      			cdr.write_type_6(data.maximum_contact_force[i0]);
            }
        }
      	if(data.rho_weight_divider == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int rho_weight_divider_length = data.rho_weight_divider.Count;
            cdr.write_type_2(rho_weight_divider_length);
            for (int i0 = 0; i0 < rho_weight_divider_length; i0++)
            {
      			cdr.write_type_6(data.rho_weight_divider[i0]);
            }
        }
   }

   public static void read(halodi_msgs.msg.ContactPointCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.parent_joint = halodi_msgs.msg.JointNamePubSubType.Create();
      halodi_msgs.msg.JointNamePubSubType.read(data.parent_joint, cdr);
      	
      data.contact_point_id=cdr.read_type_2();
      	
      data.point_in_contact=cdr.read_type_7();
      	

      int normal_length = cdr.read_type_2();
      data.normal = new System.Collections.Generic.List<geometry_msgs.msg.Vector3>(normal_length);
      for(int i = 0; i < normal_length; i++)
      {
      	geometry_msgs.msg.Vector3 new_normal = geometry_msgs.msg.Vector3PubSubType.Create(); 
      	geometry_msgs.msg.Vector3PubSubType.read(new_normal, cdr);
      	data.normal.Add(new_normal);	
      	
      }

      	

      int coefficient_of_friction_length = cdr.read_type_2();
      data.coefficient_of_friction = new System.Collections.Generic.List<double>(coefficient_of_friction_length);
      for(int i = 0; i < coefficient_of_friction_length; i++)
      {
      	data.coefficient_of_friction.Add(cdr.read_type_6());
      	
      	
      }

      	

      int maximum_contact_force_length = cdr.read_type_2();
      data.maximum_contact_force = new System.Collections.Generic.List<double>(maximum_contact_force_length);
      for(int i = 0; i < maximum_contact_force_length; i++)
      {
      	data.maximum_contact_force.Add(cdr.read_type_6());
      	
      	
      }

      	

      int rho_weight_divider_length = cdr.read_type_2();
      data.rho_weight_divider = new System.Collections.Generic.List<double>(rho_weight_divider_length);
      for(int i = 0; i < rho_weight_divider_length; i++)
      {
      	data.rho_weight_divider.Add(cdr.read_type_6());
      	
      	
      }

      	

   }


	public override void Serialize(halodi_msgs.msg.ContactPointCommand data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.ContactPointCommand data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.ContactPointCommand data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.ContactPointCommand src, halodi_msgs.msg.ContactPointCommand target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.ContactPointCommand src, halodi_msgs.msg.ContactPointCommand target)
    {
    	Copy(src, target);
    }


}


}