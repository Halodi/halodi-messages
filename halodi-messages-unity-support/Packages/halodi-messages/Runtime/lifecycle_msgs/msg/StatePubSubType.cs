using System.IO;
namespace lifecycle_msgs.msg
{

/**
* 
* Topic data type of the struct "State" defined in "State.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from State.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit State.idl instead.
*
*/
public class StatePubSubType : Halodi.CDR.TopicDataType<State>
{
   public override string Name => "lifecycle_msgs::msg::dds_::State_";


   public static int getCdrSerializedSize(lifecycle_msgs.msg.State data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(lifecycle_msgs.msg.State data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.label.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(lifecycle_msgs.msg.State data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.id);

      cdr.write_type_d(data.label);

   }

   public static void read(lifecycle_msgs.msg.State data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.id=cdr.read_type_9();
      	
      data.label = cdr.read_type_d();	

   }


	public override void Serialize(lifecycle_msgs.msg.State data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(lifecycle_msgs.msg.State data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(lifecycle_msgs.msg.State data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(lifecycle_msgs.msg.State src, lifecycle_msgs.msg.State target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(lifecycle_msgs.msg.State src, lifecycle_msgs.msg.State target)
    {
    	Copy(src, target);
    }


}


}