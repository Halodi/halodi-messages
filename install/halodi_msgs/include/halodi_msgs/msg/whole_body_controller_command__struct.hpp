// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/WholeBodyControllerCommand.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_CONTROLLER_COMMAND__STRUCT_HPP_
#define HALODI_MSGS__MSG__WHOLE_BODY_CONTROLLER_COMMAND__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'balance_mode'
#include "halodi_msgs/msg/balance_mode__struct.hpp"
// Member 'task_space_commands'
#include "halodi_msgs/msg/task_space_command__struct.hpp"
// Member 'joint_space_commands'
#include "halodi_msgs/msg/joint_space_command__struct.hpp"
// Member 'contact_point_commands'
#include "halodi_msgs/msg/contact_point_command__struct.hpp"
// Member 'driving_command'
#include "halodi_msgs/msg/driving_command__struct.hpp"
// Member 'icp_command'
#include "geometry_msgs/msg/vector3__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__WholeBodyControllerCommand __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__WholeBodyControllerCommand __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct WholeBodyControllerCommand_
{
  using Type = WholeBodyControllerCommand_<ContainerAllocator>;

  explicit WholeBodyControllerCommand_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : balance_mode(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->sequence_id = 0l;
    }
  }

  explicit WholeBodyControllerCommand_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : balance_mode(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->sequence_id = 0l;
    }
  }

  // field types and members
  using _sequence_id_type =
    int32_t;
  _sequence_id_type sequence_id;
  using _balance_mode_type =
    halodi_msgs::msg::BalanceMode_<ContainerAllocator>;
  _balance_mode_type balance_mode;
  using _task_space_commands_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::TaskSpaceCommand_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::TaskSpaceCommand_<ContainerAllocator>>::other>;
  _task_space_commands_type task_space_commands;
  using _joint_space_commands_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>, 25, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>::other>;
  _joint_space_commands_type joint_space_commands;
  using _contact_point_commands_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>::other>;
  _contact_point_commands_type contact_point_commands;
  using _driving_command_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::DrivingCommand_<ContainerAllocator>, 20, typename ContainerAllocator::template rebind<halodi_msgs::msg::DrivingCommand_<ContainerAllocator>>::other>;
  _driving_command_type driving_command;
  using _icp_command_type =
    rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Vector3_<ContainerAllocator>, 20, typename ContainerAllocator::template rebind<geometry_msgs::msg::Vector3_<ContainerAllocator>>::other>;
  _icp_command_type icp_command;

  // setters for named parameter idiom
  Type & set__sequence_id(
    const int32_t & _arg)
  {
    this->sequence_id = _arg;
    return *this;
  }
  Type & set__balance_mode(
    const halodi_msgs::msg::BalanceMode_<ContainerAllocator> & _arg)
  {
    this->balance_mode = _arg;
    return *this;
  }
  Type & set__task_space_commands(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::TaskSpaceCommand_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::TaskSpaceCommand_<ContainerAllocator>>::other> & _arg)
  {
    this->task_space_commands = _arg;
    return *this;
  }
  Type & set__joint_space_commands(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>, 25, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointSpaceCommand_<ContainerAllocator>>::other> & _arg)
  {
    this->joint_space_commands = _arg;
    return *this;
  }
  Type & set__contact_point_commands(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::ContactPointCommand_<ContainerAllocator>>::other> & _arg)
  {
    this->contact_point_commands = _arg;
    return *this;
  }
  Type & set__driving_command(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::DrivingCommand_<ContainerAllocator>, 20, typename ContainerAllocator::template rebind<halodi_msgs::msg::DrivingCommand_<ContainerAllocator>>::other> & _arg)
  {
    this->driving_command = _arg;
    return *this;
  }
  Type & set__icp_command(
    const rosidl_generator_cpp::BoundedVector<geometry_msgs::msg::Vector3_<ContainerAllocator>, 20, typename ContainerAllocator::template rebind<geometry_msgs::msg::Vector3_<ContainerAllocator>>::other> & _arg)
  {
    this->icp_command = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__WholeBodyControllerCommand
    std::shared_ptr<halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__WholeBodyControllerCommand
    std::shared_ptr<halodi_msgs::msg::WholeBodyControllerCommand_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const WholeBodyControllerCommand_ & other) const
  {
    if (this->sequence_id != other.sequence_id) {
      return false;
    }
    if (this->balance_mode != other.balance_mode) {
      return false;
    }
    if (this->task_space_commands != other.task_space_commands) {
      return false;
    }
    if (this->joint_space_commands != other.joint_space_commands) {
      return false;
    }
    if (this->contact_point_commands != other.contact_point_commands) {
      return false;
    }
    if (this->driving_command != other.driving_command) {
      return false;
    }
    if (this->icp_command != other.icp_command) {
      return false;
    }
    return true;
  }
  bool operator!=(const WholeBodyControllerCommand_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct WholeBodyControllerCommand_

// alias to use template instance with default allocator
using WholeBodyControllerCommand =
  halodi_msgs::msg::WholeBodyControllerCommand_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_CONTROLLER_COMMAND__STRUCT_HPP_
