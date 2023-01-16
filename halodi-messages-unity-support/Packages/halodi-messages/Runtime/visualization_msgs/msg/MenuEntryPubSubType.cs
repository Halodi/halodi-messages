using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "MenuEntry" defined in "MenuEntry.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MenuEntry.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MenuEntry.idl instead.
*
*/
public class MenuEntryPubSubType : Halodi.CDR.TopicDataType<MenuEntry>
{
   public override string Name => "visualization_msgs::msg::dds_::MenuEntry_";


   public static int getCdrSerializedSize(visualization_msgs.msg.MenuEntry data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.MenuEntry data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.title.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.command.Length + 1;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.MenuEntry data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_4(data.id);

      cdr.write_type_4(data.parent_id);

      cdr.write_type_d(data.title);

      cdr.write_type_d(data.command);

      cdr.write_type_9(data.command_type);

   }

   public static void read(visualization_msgs.msg.MenuEntry data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.id=cdr.read_type_4();
      	
      data.parent_id=cdr.read_type_4();
      	
      data.title = cdr.read_type_d();	
      data.command = cdr.read_type_d();	
      data.command_type=cdr.read_type_9();
      	

   }


	public override void Serialize(visualization_msgs.msg.MenuEntry data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(visualization_msgs.msg.MenuEntry data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(visualization_msgs.msg.MenuEntry data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(visualization_msgs.msg.MenuEntry src, visualization_msgs.msg.MenuEntry target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(visualization_msgs.msg.MenuEntry src, visualization_msgs.msg.MenuEntry target)
    {
    	Copy(src, target);
    }


}


}