using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "HandCommand" defined in "HandCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from HandCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit HandCommand.idl instead.
*
*/
public class HandCommandPubSubType : Halodi.CDR.TopicDataType<HandCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::HandCommand_";


   public static int getCdrSerializedSize(halodi_msgs.msg.HandCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.HandCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.HandCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.closure);

      cdr.write_type_6(data.speed);

      cdr.write_type_6(data.force);

   }

   public static void read(halodi_msgs.msg.HandCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.closure=cdr.read_type_6();
      	
      data.speed=cdr.read_type_6();
      	
      data.force=cdr.read_type_6();
      	

   }


	public override void Serialize(halodi_msgs.msg.HandCommand data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(halodi_msgs.msg.HandCommand data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(halodi_msgs.msg.HandCommand data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(halodi_msgs.msg.HandCommand src, halodi_msgs.msg.HandCommand target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(halodi_msgs.msg.HandCommand src, halodi_msgs.msg.HandCommand target)
    {
    	Copy(src, target);
    }


}


}