using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "JointSpaceCommand" defined in "JointSpaceCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointSpaceCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointSpaceCommand.idl instead.
*
*/
public class JointSpaceCommandPubSubType : Halodi.CDR.TopicDataType<halodi_msgs.msg.JointSpaceCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::JointSpaceCommand_";


   
   public override void serialize(halodi_msgs.msg.JointSpaceCommand data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.JointSpaceCommand data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointSpaceCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointSpaceCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.JointNamePubSubType.getCdrSerializedSize(data.joint, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.q_desired_filter_break_frequency.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.JointSpaceCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.JointNamePubSubType.write(data.joint, cdr);

      cdr.write_type_6(data.q_desired);

      cdr.write_type_6(data.qd_desired);

      cdr.write_type_6(data.qdd_desired);

      	if(data.q_desired_filter_break_frequency == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int q_desired_filter_break_frequency_length = data.q_desired_filter_break_frequency.Count;
            cdr.write_type_2(q_desired_filter_break_frequency_length);
            for (int i0 = 0; i0 < q_desired_filter_break_frequency_length; i0++)
            {
      			cdr.write_type_6(data.q_desired_filter_break_frequency[i0]);
            }
        }
      cdr.write_type_7(data.derive_qd_desired);

      cdr.write_type_7(data.use_default_gains);

      cdr.write_type_6(data.stiffness);

      cdr.write_type_6(data.damping);

      cdr.write_type_6(data.motorDampingScale);

      cdr.write_type_6(data.max_feedback);

   }

   public static void read(halodi_msgs.msg.JointSpaceCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.joint = halodi_msgs.msg.JointNamePubSubType.Create();
      halodi_msgs.msg.JointNamePubSubType.read(data.joint, cdr);
      	
      data.q_desired=cdr.read_type_6();
      	
      data.qd_desired=cdr.read_type_6();
      	
      data.qdd_desired=cdr.read_type_6();
      	

      int q_desired_filter_break_frequency_length = cdr.read_type_2();
      data.q_desired_filter_break_frequency = new System.Collections.Generic.List<double>(q_desired_filter_break_frequency_length);
      for(int i = 0; i < q_desired_filter_break_frequency_length; i++)
      {
      	data.q_desired_filter_break_frequency.Add(cdr.read_type_6());
      	
      	
      }

      	
      data.derive_qd_desired=cdr.read_type_7();
      	
      data.use_default_gains=cdr.read_type_7();
      	
      data.stiffness=cdr.read_type_6();
      	
      data.damping=cdr.read_type_6();
      	
      data.motorDampingScale=cdr.read_type_6();
      	
      data.max_feedback=cdr.read_type_6();
      	

   }


    public static void Copy(halodi_msgs.msg.JointSpaceCommand src, halodi_msgs.msg.JointSpaceCommand target)
    {
        target.Set(src);
    }


}


}