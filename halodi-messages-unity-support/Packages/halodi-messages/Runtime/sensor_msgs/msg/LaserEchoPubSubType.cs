using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "LaserEcho" defined in "LaserEcho.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from LaserEcho.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit LaserEcho.idl instead.
*
*/
public class LaserEchoPubSubType : Halodi.CDR.TopicDataType<LaserEcho>
{
   public override string Name => "sensor_msgs::msg::dds_::LaserEcho_";


   public static int getCdrSerializedSize(sensor_msgs.msg.LaserEcho data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.LaserEcho data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.echoes.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.LaserEcho data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.echoes == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int echoes_length = data.echoes.Count;
            cdr.write_type_2(echoes_length);
            for (int i0 = 0; i0 < echoes_length; i0++)
            {
      			cdr.write_type_5(data.echoes[i0]);
            }
        }   }

   public static void read(sensor_msgs.msg.LaserEcho data, Halodi.CDR.CDRDeserializer cdr)
   {

      int echoes_length = cdr.read_type_2();
      data.echoes = new System.Collections.Generic.List<float>(echoes_length);
      for(int i = 0; i < echoes_length; i++)
      {
      	data.echoes.Add(cdr.read_type_5());
      	
      	
      }

      	

   }


	public override void Serialize(sensor_msgs.msg.LaserEcho data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.LaserEcho data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.LaserEcho data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.LaserEcho src, sensor_msgs.msg.LaserEcho target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.LaserEcho src, sensor_msgs.msg.LaserEcho target)
    {
    	Copy(src, target);
    }


}


}