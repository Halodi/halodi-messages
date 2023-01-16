using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "StopCommand" defined in "StopCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from StopCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit StopCommand.idl instead.
*
*/
public class StopCommandPubSubType : Halodi.CDR.TopicDataType<StopCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::StopCommand_";


   public static int getCdrSerializedSize(halodi_msgs.msg.StopCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.StopCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.StopCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.stop_command);

   }

   public static void read(halodi_msgs.msg.StopCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.stop_command=cdr.read_type_2();
      	

   }


	public override void Serialize(halodi_msgs.msg.StopCommand data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.StopCommand data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.StopCommand data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.StopCommand src, halodi_msgs.msg.StopCommand target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.StopCommand src, halodi_msgs.msg.StopCommand target)
    {
    	Copy(src, target);
    }


}


}