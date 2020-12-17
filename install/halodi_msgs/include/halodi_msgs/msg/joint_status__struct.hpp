// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/JointStatus.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_STATUS__STRUCT_HPP_
#define HALODI_MSGS__MSG__JOINT_STATUS__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'joint'
#include "halodi_msgs/msg/joint_name__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__JointStatus __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__JointStatus __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct JointStatus_
{
  using Type = JointStatus_<ContainerAllocator>;

  explicit JointStatus_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : joint(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->status_level = 0;
      this->critical_for_balance = false;
      this->output_encoder_fault = false;
      this->tension_ropes = false;
    }
  }

  explicit JointStatus_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : joint(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->status_level = 0;
      this->critical_for_balance = false;
      this->output_encoder_fault = false;
      this->tension_ropes = false;
    }
  }

  // field types and members
  using _joint_type =
    halodi_msgs::msg::JointName_<ContainerAllocator>;
  _joint_type joint;
  using _status_level_type =
    unsigned char;
  _status_level_type status_level;
  using _critical_for_balance_type =
    bool;
  _critical_for_balance_type critical_for_balance;
  using _output_encoder_fault_type =
    bool;
  _output_encoder_fault_type output_encoder_fault;
  using _tension_ropes_type =
    bool;
  _tension_ropes_type tension_ropes;

  // setters for named parameter idiom
  Type & set__joint(
    const halodi_msgs::msg::JointName_<ContainerAllocator> & _arg)
  {
    this->joint = _arg;
    return *this;
  }
  Type & set__status_level(
    const unsigned char & _arg)
  {
    this->status_level = _arg;
    return *this;
  }
  Type & set__critical_for_balance(
    const bool & _arg)
  {
    this->critical_for_balance = _arg;
    return *this;
  }
  Type & set__output_encoder_fault(
    const bool & _arg)
  {
    this->output_encoder_fault = _arg;
    return *this;
  }
  Type & set__tension_ropes(
    const bool & _arg)
  {
    this->tension_ropes = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::JointStatus_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::JointStatus_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointStatus_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointStatus_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointStatus_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointStatus_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointStatus_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointStatus_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointStatus_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointStatus_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__JointStatus
    std::shared_ptr<halodi_msgs::msg::JointStatus_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__JointStatus
    std::shared_ptr<halodi_msgs::msg::JointStatus_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const JointStatus_ & other) const
  {
    if (this->joint != other.joint) {
      return false;
    }
    if (this->status_level != other.status_level) {
      return false;
    }
    if (this->critical_for_balance != other.critical_for_balance) {
      return false;
    }
    if (this->output_encoder_fault != other.output_encoder_fault) {
      return false;
    }
    if (this->tension_ropes != other.tension_ropes) {
      return false;
    }
    return true;
  }
  bool operator!=(const JointStatus_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct JointStatus_

// alias to use template instance with default allocator
using JointStatus =
  halodi_msgs::msg::JointStatus_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__JOINT_STATUS__STRUCT_HPP_
